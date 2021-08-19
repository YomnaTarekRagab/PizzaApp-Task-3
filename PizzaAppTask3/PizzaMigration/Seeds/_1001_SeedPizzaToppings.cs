using FluentMigrator;

namespace PizzaMigration.Seeds
{
    public class PizzaToppings
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    [Migration(1001)]
    public class _1001_SeedPizzaToppings : FluentMigrator.Migration
    {
        public static List<PizzaToppings> PizzaTopping = new()
        {
            new() { Name = "Chicken BBQ", Price = 15 },
            new() { Name = "Shrimps", Price = 30 },
            new() { Name = "Pepperoni", Price = 12.5 },
            new() { Name = "Vegetables", Price = 8.4 },
            new() { Name = "Meat", Price = 17.5 },
        };

        public override void Up()
        {
            foreach(var topping in PizzaTopping)
            {
                Insert.IntoTable(Tables.PizzaToppings).Row(
                    new
                    {
                        Toppings = topping.Name,
                        Price = topping.Price
                    });
            }
        }
    }
}
