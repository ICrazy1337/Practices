using System;
using System.Collections.Generic;

namespace Internet_Shop__practice_5_.Models
{
    public partial class Filter
    {
        public Filter()
        {
            Types = new HashSet<Type>();
        }

        public int Id { get; set; }
        public string Filter1 { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool IsDeleted { get; set; }

        public virtual ICollection<Type> Types { get; set; }
    }
}
