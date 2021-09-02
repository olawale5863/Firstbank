using System;
using System.Collections.Generic;

namespace FIRSTBANKOFNIGERIA.Models
{
    public partial class CustomerInformation
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateofBirth { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
    }
}
