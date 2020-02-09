﻿/*
 * William Brown
 * PecosPulledPork.cs
 * Class to define the pecos pulled pork entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the pecos pulled pork entree
    /// </summary>
    public class PecosPulledPork : Entree
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories in the entree
        /// </summary>
        public override uint Calories
        {
            get { return 528; }
        }
        /// <summary>
        /// If the entree comes with bread
        /// </summary>
        public bool Bread { get; set; } = true;
        /// <summary>
        /// If the entree comes with a pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Instructions for preparing the pulled pork
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bread)
                {
                    instructions.Add("hold bread");
                }
                if (!Pickle)
                {
                    instructions.Add("hold pickle");
                }
                return instructions;
            }
        }
    }
}