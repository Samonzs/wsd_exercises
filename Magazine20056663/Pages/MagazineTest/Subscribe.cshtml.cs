using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Magazine20056663.Pages.MagazineTest
{
    public class SubscribeModel : PageModel
    {
        // GET: https://localhost:44301/MagazineTest/Subscribe?MagazineID=3&NumIssues=4

        public void OnGet(int magazineID, int numIssues)
        {

            double price = 0;
            string name = "";

            switch (magazineID)
            {
                case 1:
                    price = 6.50;
                    name = "Scientific American";
                    break;
                case 2:
                    price = 6.0;
                    name = "New Scientific";
                    break;
                case 3:
                    price = 5.0;
                    name = "Reader's Digest";
                    break;
                case 4:
                    price = 7.0;
                    name = "National Geographic";
                    break;
            }
            double total = numIssues * price;

            ViewData["Magazine Name"] = name;
            ViewData["Total:"] = total;
            ViewData["MagazineID"] = magazineID;

        }
    }
}
