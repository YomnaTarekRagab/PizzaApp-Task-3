using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace PizzaMigration.Migrations
{
    [Migration(005)]
    public class _005_Pizza : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("pizzas_list")
                            .WithIdColumn().Indexed()
                            .WithColumn("orders_id").AsInt32().NotNullable().ForeignKey("orders_list", "id").PrimaryKey()
                            .WithNameColumn("topping").ForeignKey("pizza_toppings", "toppings")
                            .WithNameColumn("size").ForeignKey("pizza_sizes", "sizes")
                            .WithNameColumn("side").ForeignKey("pizza_sides", "sides")
                            .WithColumn("price_per_pizza").AsDouble().NotNullable();
        }
    }
}
