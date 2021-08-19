using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace PizzaMigration.Migrations
{
    [Migration(2)]
    public class _002_PizzaSizes : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("PizzaSizes")
                            .WithIdColumn()
                            .WithNameColumn("Sizes")
                            .WithPriceColumn();
        }
    }
}
