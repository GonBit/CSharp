using System;
using System.Collections.Generic;

namespace NorthwindRazorPages.Models.DB
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
