using System;
using System.Collections.Generic;

namespace Internet_Shop__practice_5_.Models
{
    public partial class Cart
    {
        public int UsersId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual User Users { get; set; } = null!;
    }
}
