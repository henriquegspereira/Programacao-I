using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyLibrary
{
    public class Apartment : Property
    {
        public int floor { get; set; }
        public bool hasElevator { get; set; }
    }
}
