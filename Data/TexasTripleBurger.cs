using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTripleBurger
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public double Price { get; } = 6.45;
        /// <summary>
        /// The calories in the entree
        /// </summary>
        public uint Calories { get; } = 698;

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
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Pickle) { instructions.Add("Hold Pickle"); }
                if (!Bun) { instructions.Add("Hold bun"); }
                if (!Ketchup) { instructions.Add("Hold ketchup"); }
                if (!Mustard) { instructions.Add("Hold mustard"); }
                if (!Cheese) { instructions.Add("Hold cheese"); }
                if (!Tomato) { instructions.Add("Hold tomato"); }
                if (!Lettuce) { instructions.Add("Hold lettuce"); }
                if (!Mayo) { instructions.Add("Hold mayo"); }
                if (!Bacon) { instructions.Add("Hold bacon"); }
                if (!Egg) { instructions.Add("Hold egg"); }
                return instructions;
            }
        }
    }
}
