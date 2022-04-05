#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NorthwindRazorPages.Models.DB;

namespace NorthwindRazorPages.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private readonly NorthwindRazorPages.Models.DB.NorthwindContext _context;

        public CreateModel(NorthwindRazorPages.Models.DB.NorthwindContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ReportsTo"] = new SelectList(_context.Employees, "EmployeeId", "EmployeeId");
            return Page();
        }

        [BindProperty]
        public Employee Employee { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Employees.Add(Employee);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
