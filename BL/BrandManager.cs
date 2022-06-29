using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Entities;

namespace BL
{
    public class BrandManager
    {
        DatabaseContext context = new DatabaseContext();

        public int Add(Brand brand)
        {
            context.Brands.Add(brand);
            return context.SaveChanges();
        }

        public List<Brand> GetAll()
        {
            return context.Brands.ToList();
        }

        public Brand Get(int id)
        {
            return context.Brands.Find(id);
        }

        public int Update(Brand brand)
        {
            context.Brands.AddOrUpdate(brand);
            return context.SaveChanges();
        }

        public int Delete(int id)
        {
            context.Brands.Remove(this.Get(id));
            return context.SaveChanges();
        }
    }
}
