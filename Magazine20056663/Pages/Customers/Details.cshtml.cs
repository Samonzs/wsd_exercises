using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Magazine20056663.Data;
using Magazine20056663.ModelClasses;

namespace Magazine20056663.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly Magazine20056663.Data.Magazine20056663Context _context;

        public DetailsModel(Magazine20056663.Data.Magazine20056663Context context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.customerID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
