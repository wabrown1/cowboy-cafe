/*
 * William Brown
 * RustlersRibs.cs
 * Class to define the rustler's ribs entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public override double Price {
            get
            {
                return 7.5;
            }
        }

        /// <summary>
        /// The number of calories in the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// The instructions for preparing the entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }
    }
}
