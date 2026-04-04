    using System;
    using System.Collections.Generic;
    using System.Text;
    using Core.Enums;

namespace PropertyLibrary
    {
        #region Attributes
        public class House : Property
        {
            public int Floors { get; set; }

            public bool HasGarage { get; set; }

        #endregion

        #region Constructors
        public House() { }

        public House(
            int id, 
            PropertyEnums.PropertyType type, 
            PropertyEnums.ContractType contract, 
            string name, 
            string address, 
            string description, 
            decimal price, 
            int area, 
            int bedrooms, 
            int floors, 
            bool hasGarage
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
            Floors = floors;
            HasGarage = hasGarage;
        }
        #endregion

        #region Validations
        public override bool Validate()
        {
            return base.Validate() && Floors > 0;
        }
        #endregion
    }
}
