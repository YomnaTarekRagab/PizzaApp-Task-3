using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace PizzaMigration.Migrations
{
    [Migration(1)]
    public class _001_PizzaToppings: AutoReversingMigration 
    {
        public override void Up()
        {
            Create.Table("PizzaToppings")
                            .WithIdColumn()
                            .WithNameColumn("Toppings")
                            .WithPriceColumn();
        }
    }
}
