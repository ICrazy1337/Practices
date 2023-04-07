using System;
using System.Collections.Generic;

namespace Internet_Shop__practice_5_.Models
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool Avaible { get; set; }
        public int TypeId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Type Type { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
