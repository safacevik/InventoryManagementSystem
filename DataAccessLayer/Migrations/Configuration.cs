using Entities;

namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            //ContextKey = "DataAccessLayer.DatabaseContext";
        }

        protected override void Seed(DataAccessLayer.DatabaseContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.Add
                (
                    new User()
                    {
                        UserName = "safacevik",
                        Password = "123456",
                        Name = "Safa",
                        Surname = "Çevik",
                        Email = "safa@example.com",
                        PhoneNumber = "+901112224455"
                    }
                );
                context.SaveChanges();
            }
            base.Seed(context);
        }
    }
}
