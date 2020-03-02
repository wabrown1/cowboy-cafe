using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        static uint orderNumber = 0;
        public uint OrderNumber
        {
            get
            {
                return ++orderNumber;
            }
        }

        List<IOrderItem> items = new List<IOrderItem>();

        //Hide items data by creating a copy of the data
        public IEnumerable<IOrderItem> Items => items.ToArray();

        // public IEnumerable<IOrderItem> Items => throw new NotImplementedException();

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

        public void Add(IOrderItem item)
        {
            items.Add(item);
            //? checks if null(no event listeners) and runs if not null
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
