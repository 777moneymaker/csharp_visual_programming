﻿namespace Library.Migrations {
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Library.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Library.DataContext";
        }

        protected override void Seed(Library.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
