﻿using FluentMigrator.Builders.Create.Table;
using PizzaApp;
using System.Collections.Generic;

namespace PizzaMigration
{
    public static class PostgresSpecificType
    {
        
    }
    public static class Common
    {
        public static ICreateTableColumnOptionOrWithColumnSyntax
            WithIdColumn(this ICreateTableWithColumnSyntax tableWithColumnSyntax)
        {
            return tableWithColumnSyntax
                .WithColumn("id")
                .AsInt32()
                .NotNullable()
                .PrimaryKey()
                .Identity();
        }

        public static ICreateTableColumnOptionOrWithColumnSyntax
            WithNameColumn(this ICreateTableWithColumnSyntax tableWithColumnSyntax, string tableName)
        {
            return tableWithColumnSyntax
                .WithColumn(tableName)
                .AsString()
                .NotNullable();
        }

        public static ICreateTableColumnOptionOrWithColumnSyntax
            WithPriceColumn(this ICreateTableWithColumnSyntax tableWithColumnSyntax)
        {
            return tableWithColumnSyntax
                .WithColumn("Price")
                .AsDouble()
                .NotNullable();
        }

    }
}
