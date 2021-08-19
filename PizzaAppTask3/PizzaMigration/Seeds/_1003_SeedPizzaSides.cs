using FluentMigrator;

namespace PizzaMigration.Seeds
{
    public class PizzaSides
    {
        public string Type { get; set; }
        public double Price { get; set; }
    }

    [Migration(3)]
    public class _1003_SeedPizzaSides : FluentMigrator.Migration
    {
        public static List<PizzaSides> PizzaSide = new()
        {
            new() { Type = "Fries", Price = 5.5 },
            new() { Type = "None", Price = 0.0 },
            new() { Type = "Cookie", Price = 3.5 },
            new() { Type = "Salad", Price = 9.8 },
            new() { Type = "Garlic Bread", Price = 7.7 },
        };

        public override void Up()
        {
            foreach (var side in PizzaSide)
            {
                Insert.IntoTable(Tables.PizzaSides).Row(
                    new
                    {
                        Sides = side.Type,
                        Price = side.Price
                    });
            }
        }
    }
}
