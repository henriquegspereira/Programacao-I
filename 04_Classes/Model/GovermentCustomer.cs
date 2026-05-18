using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class GovermentCustomer : Customer
    {
        public string FiscalCode { get; set; } = string.Empty;
        public GovermentCustomer() 
        { 
        }
    }
}
