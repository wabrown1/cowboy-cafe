/*
 * William Brown
 * TexasTea.cs
 * Class to define the Texas Tea drink
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing Texas tea
    /// </summary>
    public class TexasTea : Drink
    {
        private bool sweet = true;
        /// <summary>
        /// If the tea is served with sweetener
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set
            {
                sweet = value;
                NotifyOfPropertyChange("Sweet");
            }
        }

        private bool lemon = false;
        /// <summary>
        /// If the tea is served with lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                NotifyOfPropertyChange("Lemon");
            }
        }

        /// <summary>
        /// The price of the tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1;
                    case Size.Medium:
                        return 1.5;
                    case Size.Large:
                        return 2;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calories in the tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint calories;
                switch (Size)
                {
                    case Size.Small:
                        calories = 10;
                        break;
                    case Size.Medium:
                        calories = 22;
                        break;
                    case Size.Large:
                        calories = 36;
                        break;
                    default:
                        throw new NotImplementedException();
                }
                if (!Sweet)
                {
                    calories /= 2;
                }
                return calories;
            }
        }

        /// <summary>
        /// Instructions for how to prepare the tea
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Ice)
                {
                    instructions.Add("Hold Ice");
                }
                if (Lemon)
                {
                    instructions.Add("Add Lemon");
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
            if (Sweet)
            {
                return $"{Size} Texas Sweet Tea";
            }
            return $"{Size} Texas Plain Tea";
        }
    }
}
