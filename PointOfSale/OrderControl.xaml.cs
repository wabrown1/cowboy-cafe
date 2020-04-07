/*
 * William Brown
 * OrderControl.cs
 * Class to handle to order control user interface
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {        
        Order o = new Order();

        /// <summary>
        /// Constructor to create event listeners for each button
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            this.DataContext = o;
            CancelOrderButton.Click += OnCancelOrderButtonClicked;
            CompleteOrderButton.Click += OnCompleteOrderButtonClicked;
            ItemSelectionButton.Click += OnItemSelectionButtonClicked;

            //OrderSummaryControl.ItemsList.SelectionChanged += OnListBoxItemSelected;
        }
        /// <summary>
        /// The same cash drawer to be used for every order
        /// </summary>
        public static CashDrawer CashDrawer = new CashDrawer();

        /// <summary>
        /// The total current value of the drawer
        /// </summary>
        public double TotalValue => CashDrawer.TotalValue;

        /// <summary>
        /// Clears the order when the cancel button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            //this.DataContext = new Order();
            //CowboyCafe.Data.Order.OrderNumber
            this.DataContext = new Order(1);
            SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// Clears the order when the complete order button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCompleteOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            //this.DataContext = new Order();
            SwapScreen(new TransactionControl());
        }

        //public void SwapScreen(FrameworkElement element)
        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }

        public void OnItemSelectionButtonClicked(object sender, RoutedEventArgs e)
        {
            SwapScreen(new MenuItemSelectionControl());
        }
    }
}
