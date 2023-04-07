using System;
using System.Collections.Generic;

namespace Internet_Shop__practice_5_.Models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Role1 { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool IsDeleted { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
