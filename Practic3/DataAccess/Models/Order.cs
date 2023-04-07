using System;
using System.Collections.Generic;

namespace Internet_Shop__practice_5_.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int StatusId { get; set; }
        public DateTime Date { get; set; }
        public int UsersId { get; set; }
        public int ProductId { get; set; }
        public int DeliveryId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Delivery Delivery { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
        public virtual User Users { get; set; } = null!;
    }
}
