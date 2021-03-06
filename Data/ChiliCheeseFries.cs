﻿/*
 * William Brown
 * ChiliCheeseFries.cs
 * Class to define the chili cheese fries side
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Defines properties of the chili cheese fries side
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// The price of the side
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calories in the side
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Overrides the ToString method for display in the wpf
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Chili Cheese Fries";
        }
    }
}
