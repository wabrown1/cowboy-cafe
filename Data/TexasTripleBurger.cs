﻿/*
 * William Brown
 * TexasTripleBurger.cs
 * Class to define the Texas triple burger entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTripleBurger : Entree
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public override double Price { get; } = 6.45;
        /// <summary>
        /// The calories in the entree
        /// </summary>
        public override uint Calories { get; } = 698;

        /// <summary>
        /// If the burger is served with a pickle
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// If the burger is served with a bun
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// If the burger is served with ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// If the burger is served with mustard
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// If the burger is served with cheese
        /// </summary>
        public bool Cheese { get; set; } = true;
        /// <summary>
        /// If the burger is served with tomato
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// If the burger is served with lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// If the burger is served with mayo
        /// </summary>
        public bool Mayo { get; set; } = true;
        /// <summary>
        /// If the burger is served with bacon
        /// </summary>
        public bool Bacon { get; set; } = true;
        /// <summary>
        /// If the burger is served with egg
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// The instructions for preparing the entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Pickle) { instructions.Add("hold pickle"); }
                if (!Bun) { instructions.Add("hold bun"); }
                if (!Ketchup) { instructions.Add("hold ketchup"); }
                if (!Mustard) { instructions.Add("hold mustard"); }
                if (!Cheese) { instructions.Add("hold cheese"); }
                if (!Tomato) { instructions.Add("hold tomato"); }
                if (!Lettuce) { instructions.Add("hold lettuce"); }
                if (!Mayo) { instructions.Add("hold mayo"); }
                if (!Bacon) { instructions.Add("hold bacon"); }
                if (!Egg) { instructions.Add("hold egg"); }
                return instructions;
            }
        }

        /// <summary>
        /// Override of the ToString method for use in the wpf
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}
