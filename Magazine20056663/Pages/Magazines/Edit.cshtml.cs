using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Magazine20056663.Data;
using Magazine20056663.Pages.MagazineTest.Classes;

namespace Magazine20056663.Pages.Magazines
{
    public class EditModel : PageModel
    {
        private readonly Magazine20056663.Data.Magazine20056663Context _context;

        public EditModel(Magazine20056663.Data.Magazine20056663Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Magazine Magazine { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Magazine = await _context.Magazine.FirstOrDefaultAsync(m => m.magazineID == id);

            if (Magazine == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Magazine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MagazineExists(Magazine.magazineID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MagazineExists(int id)
        {
            return _context.Magazine.Any(e => e.magazineID == id);
        }
    }
}
