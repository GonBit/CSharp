using System;
using System.Collections.Generic;

namespace NorthwindRazorPages.Models.DB
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
    }
}
