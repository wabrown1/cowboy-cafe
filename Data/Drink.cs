/*
 * William Brown
 * Drink.cs
 * Abstract base class to be used with drink classes
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class for drinks
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// The Price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// The size of the drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// The calories in the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// If the drink is to be served with ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Instructions for how to serve the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
