using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Magazine20056663.ModelClasses
{
    public class Customer
    {
        public int customerID { get; set; }
        [Required(ErrorMessage = "Family Name is Required")]
        [RegularExpression(@"[a-zA-Z-']{2,20}$", ErrorMessage = "This magazine field needs to be between 2 and 20 alphabetic characters. hyphens and apostrophe's are permitted only")]
        public string familyName { get; set; }
        [Required(ErrorMessage = "Gives Name is Required")]
        [RegularExpression(@"[a-zA-Z-']{2,20}$", ErrorMessage = "This magazine field needs to be between 2 and 20 alphabetic characters. hyphens and apostrophe's are permitted only")]

        public string givenName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public string dateOfBirth { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string emailAddress { get; set; }

        [Required(ErrorMessage = "Mobile Number is Required")]
        [RegularExpression(@"^04([0-9]{2})[ ]([0-9]{3})[ ]([0-9]{3})", ErrorMessage = "This Mobile Number is not valid, a valid number indiciates a spaces after the first on 5th and 9th index")]

        public string mobileNumber { get; set; }
        [Required(ErrorMessage = "Post Code is Required")]
        [RegularExpression(@"[0-8]{1}[0-9]{3}", ErrorMessage = "This Post Code is not valid, first digit must not start with 9")]

        public string postalCode { get; set; }

    }
}
