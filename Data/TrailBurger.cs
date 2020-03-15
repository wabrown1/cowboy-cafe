/*
 * William Brown
 * TrailBurger.cs
 * Class to define the trail burger entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the trailburger entree
    /// </summary>
    public class TrailBurger : Entree
    {
        /// <summary>
        /// The price of the trailburger
        /// </summary>
        public override double Price { get; } = 4.5;

        /// <summary>
        /// The calories in the entree
        /// </summary>
        public override uint Calories { get; } = 288;

        private bool pickle = true;
        /// <summary>
        /// If the burger is served with a pickle
        /// </summary>
        public bool Pickle
        {
            get
            {
                return pickle;
            }
            set
            {
                pickle = value;
                NotifyOfPropertyChange("Pickle");
            }
        }

        private bool bun = true;
        /// <summary>
        /// If the burger is served with a bun
        /// </summary>
        public bool Bun 
        {
            get
            {
                return bun;
            }
            set
            {
                bun = value;
                NotifyOfPropertyChange("Bun");
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// If the burger is served with ketchup
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                ketchup = value;
                NotifyOfPropertyChange("Ketchup");
            }
        }

        private bool mustard = true;
        /// <summary>
        /// If the burger is served with mustard
        /// </summary>
        public bool Mustard
        {
            get
            {
                return mustard;
            }
            set
            {
                mustard = value;
                NotifyOfPropertyChange("Mustard");
            }
        }

        private bool cheese = true;
        /// <summary>
        /// If the burger is served with cheese
        /// </summary>
        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                cheese = value;
                NotifyOfPropertyChange("Cheese");
            }
        }

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
                return instructions;
            }
        }

        /// <summary>
        /// Override of the ToString method for use in the wpf
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Trail Burger";
        }
    }
}
