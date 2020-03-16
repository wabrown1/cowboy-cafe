/*
 * William Brown
 * Order.cs
 * Class representing a single order
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        public Order()
        {
            ++orderNumber;
        }

        /// <summary>
        /// Constructor with different method signature so that a new order
        /// can be created without incrementing the order num when canceling and order
        /// </summary>
        /// <param name="orderNum">An unused variable that is needed so that the constructor has
        /// a different method signature than the above constructor</param>
        public Order(uint orderNum)
        {
            //orderNumber = orderNum;
        }

        static uint orderNumber = 0;
        /// <summary>
        /// The number of the order, updated every time a new order is created
        /// </summary>
        public uint OrderNumber
        {
            get
            {
                return orderNumber;
                //return ++orderNumber;
            }
        }

        List<IOrderItem> items = new List<IOrderItem>();

        //Hide items data by creating a copy of the data
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// The total cost of this order
        /// </summary>
        public double Subtotal 
        {
            get
            {
                double total = 0;
                foreach(IOrderItem i in items)
                {
                    total += i.Price;
                }
                return total;
            }
        } //add price of every item

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Adds an order item an checks if a property was changed
        /// </summary>
        /// <param name="item">The order item to add</param>
        public void Add(IOrderItem item)
        {
            if(item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged += OnItemPropertyChanged;
            }
            items.Add(item);
            //? checks if null(no event listeners) and runs if not null
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Removes the order item from the order and checks if a property was changed
        /// </summary>
        /// <param name="item">The order item to remove</param>
        public void Remove(IOrderItem item) 
        {
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged -= OnItemPropertyChanged;
            }
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }
    }
}
