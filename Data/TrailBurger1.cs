using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the trailburger entree
    /// </summary>
    public class TrailBurger
    {
        /// <summary>
        /// The price of the trailburger
        /// </summary>
        public double Price { get; } = 4.5;

        /// <summary>
        /// The calories in the entree
        /// </summary>
        public uint Calories { get; } = 288;

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
        /// The instructions for preparing the entree
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Pickle) { instructions.Add("Hold pickle"); }
                if (!Bun) { instructions.Add("Hold bun"); }
                if (!Ketchup) { instructions.Add("Hold ketchup"); }
                if (!Mustard) { instructions.Add("Hold mustard"); }
                if (!Cheese) { instructions.Add("Hold cheese"); }
                return instructions;
            }
        }
    }
}
