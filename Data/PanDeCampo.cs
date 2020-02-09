/*
 * William Brown
 * PanDeCampo.cs
 * Class to define the Pan de Campo side
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Defines the properties of the Pan de Campo side
    /// </summary>
    public class PanDeCampo : Side
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
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
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
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
