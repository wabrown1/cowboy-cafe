/*
 * William Brown
 * Entree.cs
 * Abstract class to define methods  and properties to be implemented
 * by entree classes 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class defining properties an entree must have
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public abstract double Price {get;}

        /// <summary>
        /// The calories in the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions for preparing the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
