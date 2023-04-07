using System;
using System.Collections.Generic;

namespace Internet_Shop__practice_5_.Models
{
    public partial class Status
    {
        public Status()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Status1 { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool IsDeleted { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
