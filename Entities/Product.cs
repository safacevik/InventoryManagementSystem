using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public DateTime UploadDate { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal WholesalePrice { get; set; }
        public virtual Category Category { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
