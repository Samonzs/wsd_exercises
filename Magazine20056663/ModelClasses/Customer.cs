using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magazine20056663.ModelClasses
{
    public class Customer
    {
        public int customerID { get; set; }
        public string familyName { get; set; }
        public string givenName { get; set; }
        public string dateOfBirth { get; set; }
        public string emailAddress { get; set; }
        public string mobileNumber { get; set; }
        public string postalCode { get; set; }
    }
}
