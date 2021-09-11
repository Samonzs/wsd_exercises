using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Magazine20056663.Pages.MagazineTest.Classes
{
    public class Magazine
    {
        public int magazineID { get; set; }
        [Display(Name = "Magazine Name")]
        [Required]
        [RegularExpression(@"[\da-zA-Z_ ]{3,20}$", ErrorMessage = "This magazine field needs to be between 3 and 20 characters. Also underscores, spaces and numeric values are permitted only")]
        public string magazineName { get; set; }

        [Display(Name = "Price Each")]
        [DataType(DataType.Currency)]
        [Range(5,20)]
        public double Price { get; set; }




    }


}
