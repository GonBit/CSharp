#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NorthwindRazorPages.Models.DB;

namespace NorthwindRazorPages.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly NorthwindRazorPages.Models.DB.NorthwindContext _context;

        public IndexModel(NorthwindRazorPages.Models.DB.NorthwindContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employees
                .Include(e => e.ReportsToNavigation).ToListAsync();
        }
    }
}
