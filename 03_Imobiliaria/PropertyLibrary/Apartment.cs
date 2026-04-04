using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Core.Enums;

namespace PropertyLibrary
{
    public class Apartment : Property
    {
        #region Attributes
        public int Floor { get; set; }
        public bool HasElevator { get; set; }

        #endregion

        #region Constructors
        public Apartment() { }

        public Apartment(
            int id,
            PropertyEnums.PropertyType type, 
            PropertyEnums.ContractType contract, 
            string name, 
            string address, 
            string description, 
            decimal price, 
            int area, 
            int bedrooms, 
            int floor, 
            bool hasElevator
        )
            : base(
                  id, 
                  type, 
                  contract, 
                  name, 
                  address, 
                  description, 
                  price, 
                  area, 
                  bedrooms
            )
        {
            Floor = floor;
            HasElevator = hasElevator;
        }
        #endregion

        #region Validations
        public override bool Validate()
        {
            return base.Validate() && Floor >= 0;
        }
        #endregion
    }
}
