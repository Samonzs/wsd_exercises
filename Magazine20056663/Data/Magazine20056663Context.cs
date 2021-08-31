using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Magazine20056663.Pages.MagazineTest.Classes;
using Magazine20056663.ModelClasses;

namespace Magazine20056663.Data
{
    public class Magazine20056663Context : DbContext
    {
        public Magazine20056663Context (DbContextOptions<Magazine20056663Context> options)
            : base(options)
        {
        }

        public DbSet<Magazine20056663.Pages.MagazineTest.Classes.Magazine> Magazine { get; set; }

        public DbSet<Magazine20056663.ModelClasses.Customer> Customer { get; set; }
    }
}
