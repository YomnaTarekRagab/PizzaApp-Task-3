using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace PizzaMigration.Migrations
{
    [Migration(5)]
    public class _005_Orders : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("OrdersList")
                            .WithIdColumn()
                            .WithColumn("NumberOfPizzas").AsInt32().NotNullable()
                            .WithColumn("TotalPrice").AsDouble().NotNullable();
        }
    }
}
