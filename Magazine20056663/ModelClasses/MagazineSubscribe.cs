using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Magazine20056663.ModelClasses
{
    public class MagazineSubscribe
    {
        [Display(Name = "Magazine Name")]
        public string magazineName { get; set; }

        [Display(Name = "Quantity")]
        [Range(1, 10)]
        public int magazineCount { get; set; }

        [Display(Name = "Credit Card")]
        [Required(ErrorMessage = "Credit Card is required ")]
        [RegularExpression(@"([0-9]{4})[ ]([0-9]{4})[ ]([0-9]{4})[ ]([0-9]{4})", ErrorMessage = "This Credit Card is not valid")]
        public string creditCard { get; set; }

    }
}
