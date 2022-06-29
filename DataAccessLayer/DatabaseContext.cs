using Entities;
using System;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public class DatabaseInitializer : CreateDatabaseIfNotExists<DatabaseContext>          
        {
            protected override void Seed(DatabaseContext context)
                                                                 
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
                            Surname = "�evik",
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
}