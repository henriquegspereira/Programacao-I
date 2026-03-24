using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyLibrary
{
    public class House : Property
    {
        public int floors { get; set; }

        public bool hasGarage { get; set; }
    }
}
