/*
 * William Brown
 * CowboyCoffee.cs
 * Class to define the cowboy coffee drink
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing cowboy coffee
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// If the coffee should have room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// If the coffee is decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// If the coffee is served with ice
        /// </summary>
        public new bool Ice { get; set; } = false;

        /// <summary>
        /// The price of the coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return .6;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.6;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calories in the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Instructions for how to prepare the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if(RoomForCream)
                {
                    instructions.Add("Room for Cream");
                }
                if(Ice)
                {
                    instructions.Add("Add Ice");
                }
                if(Decaf)
                {
                    instructions.Add("Decaf");
                }
                return instructions;
            }
        }

        /// <summary>
        /// Override of the ToString method for use in the wpf
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Decaf)
            {
                return $"{Size} Decaf Cowboy Coffee";
            }
            return $"{Size} Cowboy Coffee";
        }
    }
}
