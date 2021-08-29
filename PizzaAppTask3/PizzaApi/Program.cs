using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using PizzaApp;
using System.Text.Json;
using System;
using System.Data;
using System.Diagnostics;
using PizzaAppData;
using PizzaAppData.DatabaseSpecific;
using OrdersView.DtoClasses;
using OrdersView.Persistence;
using PizzaAppData.Linq;
using Npgsql;
using SD.LLBLGen.Pro.DQE.PostgreSql;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.LinqSupportClasses;
using System.Linq;
using PizzaAppData.EntityClasses;


var app = WebApplication.Create();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

LLBLGen();

app.MapGet("/components", async () =>
{
    using (DataAccessAdapter adapter = new DataAccessAdapter())
    {
        var metaData = new LinqMetaData(adapter);
        var toppings = await metaData.PizzaTopping.ToListAsync();
        var sizes = await metaData.PizzaSize.ToListAsync();
        var sides = await metaData.PizzaSide.ToListAsync();
        return new
        {
            Toppings = toppings.Select(x => new { x.Id, x.Toppings, x.Price }),
            Sizes = sizes.Select(x => new { x.Id, x.Sizes, x.Price }),
            Sides = sides.Select(x => new { x.Id, x.Sides, x.Price })
        };
    }
});

app.MapPost("/createPizza", async([FromBody] Order receivedOrder) =>
{
    using (DataAccessAdapter adapter = new DataAccessAdapter())
    {
        var metaData = new LinqMetaData(adapter);
        adapter.StartTransaction(IsolationLevel.ReadCommitted, "MultiEntityInsertion");
        var totalPrice = receivedOrder.TotalPrice;
        OrdersListEntity orderRow = new OrdersListEntity();
        orderRow.Id = receivedOrder.UserId;
        var orderId = orderRow.Id;
        orderRow.NumberOfPizzas = receivedOrder.NumOfPizzas;
        orderRow.TotalPrice = totalPrice;
        await adapter.SaveEntityAsync(orderRow, true);
        adapter.Commit();
        adapter.StartTransaction(IsolationLevel.ReadCommitted, "MultiEntityInsertion");
        foreach (var pizza in receivedOrder.ListOfPizzas)
        {
            
            PizzasListEntity pizzaRow = new PizzasListEntity();
            int pizzaId = pizzaRow.Id;
            pizzaRow.Topping = pizza.Topping.Type;
            pizzaRow.Size = pizza.Size.Type;
            pizzaRow.OrdersId = orderId;
            pizzaRow.Side = pizza.Side.Type;
            pizzaRow.PricePerPizza = pizza.CalculatePrice();
            await adapter.SaveEntityAsync(pizzaRow, true);
        }

        adapter.Commit();

    }
        
        //string path = Path.Combine(Directory.GetCurrentDirectory(), "Files/orders.json");
        //var options = new JsonSerializerOptions
        //{
        //WriteIndented = true,
        //IncludeFields = true
        //};
        //var orderJson = System.Text.Json.JsonSerializer.Serialize(receivedOrder, options);
        //await File.AppendAllTextAsync(path, orderJson);
        return new OkObjectResult(receivedOrder);
});

//static async Task<string> ReadOrdersList(string fileName)
//{
//    string path = Path.Combine(Directory.GetCurrentDirectory(), fileName);
//    string jsonString = await File.ReadAllTextAsync(path);
//    return jsonString;
//}

await app.RunAsync();

static void LLBLGen()
{
    var connectionString = "Server=localhost;Database=pizza_app;Port=5432;User Id=postgres;Password=root;";
    NpgsqlConnection.GlobalTypeMapper.UseNetTopologySuite(geographyAsDefault: true);
    RuntimeConfiguration.AddConnectionString("ConnectionString.PostgreSql (Npgsql)", connectionString);
    RuntimeConfiguration.ConfigureDQE<PostgreSqlDQEConfiguration>(c =>
    {
        c.AddDbProviderFactory(typeof(NpgsqlFactory));
        c.SetTraceLevel(System.Diagnostics.TraceLevel.Verbose);
    });
}