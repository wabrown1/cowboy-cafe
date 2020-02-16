/*
 * William Brown
 * Water.cs
 * Class to define the water drink
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing water
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// If the drink is served with lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// The price of the drink
        /// </summary>
        public override double Price { get => .12; }

        /// <summary>
        /// The calories in the drink
        /// </summary>
        public override uint Calories { get => 0; }

        /// <summary>
        /// Instructions for how to serve the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (Lemon)
                {
                    instructions.Add("Add Lemon");
                }
                if (!Ice)
                {
                    instructions.Add("Hold Ice");
                }
                return instructions;
            }
        }
    }
}
