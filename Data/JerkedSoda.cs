/*
 * William Brown
 * JerkedSoda.cs
 * Class to define the Jerked soda drink
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing jerked soda
    /// </summary>
    public class JerkedSoda : Drink
    {
        private SodaFlavor flavor;
        /// <summary>
        /// The flavor of the soda
        /// </summary>
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                NotifyOfPropertyChange("Flavor");
            }
        }

        /// <summary>
        /// The price of the soda
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
                        return 2.1;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calories in the soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Instructions for how to serve the soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice)
                {
                    instructions.Add("Hold Ice");
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
            switch (Flavor)
            {
                case SodaFlavor.CreamSoda:
                    return $"{Size} Cream Soda Jerked Soda";
                case SodaFlavor.OrangeSoda:
                    return $"{Size} Orange Soda Jerked Soda";
                case SodaFlavor.Sarsparilla:
                    return $"{Size} Sarsparilla Jerked Soda";
                case SodaFlavor.BirchBeer:
                    return $"{Size} Birch Beer Jerked Soda";
                case SodaFlavor.RootBeer:
                    return $"{Size} Root Beer Jerked Soda";
            }
            return $"{Size} {Flavor} Jerked Soda";
        }
    }
}
