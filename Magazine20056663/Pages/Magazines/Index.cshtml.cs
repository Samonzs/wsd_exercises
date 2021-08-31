using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Magazine20056663.Data;
using Magazine20056663.Pages.MagazineTest.Classes;

namespace Magazine20056663.Pages.Magazines
{
    public class IndexModel : PageModel
    {
        private readonly Magazine20056663.Data.Magazine20056663Context _context;

        public IndexModel(Magazine20056663.Data.Magazine20056663Context context)
        {
            _context = context;
        }

        public IList<Magazine> Magazine { get;set; }

        public async Task OnGetAsync()
        {
            Magazine = await _context.Magazine.ToListAsync();
        }
    }
}
