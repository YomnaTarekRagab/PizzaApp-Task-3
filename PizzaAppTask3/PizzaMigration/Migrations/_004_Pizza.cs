using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace PizzaMigration.Migrations
{
    [Migration(4)]
    public class _004_Pizza : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Pizzas")
                            .WithIdColumn()
                            .WithColumn("OrderId").AsInt32().NotNullable().ForeignKey("OrdersList", "id").PrimaryKey()
                            .WithNameColumn("Topping").ForeignKey("PizzaToppings", "Toppings")
                            .WithNameColumn("Sizes").ForeignKey("PizzaSizes", "Sizes")
                            .WithNameColumn("Sides").ForeignKey("PizzaSides", "Sides")
                            .WithColumn("PricePerPizza").AsDouble().NotNullable();
        }
    }
}
