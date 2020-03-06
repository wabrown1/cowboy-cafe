/*
 * William Brown
 * Entree.cs
 * Abstract class to define methods  and properties to be implemented
 * by entree classes 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class defining properties an entree must have
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The price of the entree
        /// </summary>
        public abstract double Price {get;}

        /// <summary>
        /// The calories in the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions for preparing the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Helper method to notifty of boolean customization property changes
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
