using System;
using System.Collections.Generic;

namespace Internet_Shop__practice_5_.Models
{
    public partial class Type
    {
        public Type()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Type1 { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int FilterId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Filter Filter { get; set; } = null!;
        public virtual ICollection<Product> Products { get; set; }
    }
}
