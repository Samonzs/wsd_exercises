using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Magazine20056663.ModelClasses;
using Magazine20056663.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace Magazine20056663.Pages.Magazines
{
    public class PurchaseModel : PageModel
    {
        private readonly Magazine20056663.Data.Magazine20056663Context _context;

        public PurchaseModel(Magazine20056663.Data.Magazine20056663Context context)
        {
            _context = context;
        }

        // Requires 'using Microsoft.AspNetCore.Mvc.Rendering;'
        public SelectList TitleList { get; set; }

        [BindProperty(SupportsGet = true)]
        public MagazineSubscribe MagazineSubscribe { get; set; }

        public IActionResult OnGet()
        {
            // Obtain values for the <select> list in web form
            TitleList = new SelectList(_context.Magazine, "magazineName", "magazineName");
            // Display the page
            return Page();
        }

        //public void OnGet()
        //{
        //}

        public async Task<IActionResult> OnPostAsync()
        {
            // Obtain values for the <select> list in web form
            TitleList = new SelectList(_context.Magazine, "magazineName", "magazineName");

            if (!ModelState.IsValid)  // validate user input
            {
                return Page();
            }

            var Magazine = await _context.Magazine.FirstOrDefaultAsync(m => m.magazineName == MagazineSubscribe.magazineName);
            ViewData["TotalPrice"] = Magazine.Price * MagazineSubscribe.magazineCount;
            return Page();
        }

        







        /* public void OnGet()
         {
         }*/
    }
}
