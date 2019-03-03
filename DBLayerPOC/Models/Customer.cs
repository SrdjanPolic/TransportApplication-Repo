using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.Models
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string PaymentTermsCode { get; set; }
        public int VatGroup { get; set; }
    }
}
