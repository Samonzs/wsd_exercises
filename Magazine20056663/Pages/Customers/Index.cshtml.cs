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
    public class IndexModel : PageModel
    {
        private readonly Magazine20056663.Data.Magazine20056663Context _context;

        public IndexModel(Magazine20056663.Data.Magazine20056663Context context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }


        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public async Task OnGetAsync()
        {
            var customers = (IQueryable<Customer>)_context.Customer;

            if (!String.IsNullOrEmpty(SearchString))
            {
                customers = customers.Where(s => s.givenName.Contains(SearchString));
            }

            Customer = await customers.ToListAsync();
        }

    }
}
