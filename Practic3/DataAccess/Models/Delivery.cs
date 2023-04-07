using System;
using System.Collections.Generic;

namespace Internet_Shop__practice_5_.Models
{
    public partial class Delivery
    {
        public Delivery()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public int CourierId { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; } = null!;
        public bool IsDeleted { get; set; }

        public virtual User Courier { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
