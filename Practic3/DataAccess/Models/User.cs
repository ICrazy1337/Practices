using System;
using System.Collections.Generic;

namespace Internet_Shop__practice_5_.Models
{
    public partial class User
    {
        public User()
        {
            Deliveries = new HashSet<Delivery>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string? Country { get; set; }
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<Delivery> Deliveries { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
