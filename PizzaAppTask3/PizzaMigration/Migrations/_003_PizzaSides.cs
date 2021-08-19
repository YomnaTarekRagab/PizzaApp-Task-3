using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace PizzaMigration.Migrations
{
    [Migration(3)]
    public class _003_PizzaSides : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("PizzaSides")
                            .WithIdColumn()
                            .WithNameColumn("Sides")
                            .WithPriceColumn();
        }
    }
}
