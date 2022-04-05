using System;
using System.Collections.Generic;

namespace NorthwindRazorPages.Models.DB
{
    public partial class CustomerDemographic
    {
        public CustomerDemographic()
        {
            Customers = new HashSet<Customer1>();
        }

        public string CustomerTypeId { get; set; } = null!;
        public string? CustomerDesc { get; set; }

        public virtual ICollection<Customer1> Customers { get; set; }
    }
}
