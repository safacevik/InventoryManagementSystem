﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public string OrderNum { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int OrderQuantity { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
