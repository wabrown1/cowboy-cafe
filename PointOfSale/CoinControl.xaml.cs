/*
 * William Brown
 * CoinControl.xaml.cs
 * Class to control interactions between the data and coin control gui
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
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CoinControl.xaml
    /// </summary>
    public partial class CoinControl : UserControl
    {
        /// <summary>
        /// Event to be invoked when the quantity of a given coin changes
        /// </summary>
        public event EventHandler QuantityChanged;

        /// <summary>
        /// The dependency property for the denomination property
        /// </summary>
        public static readonly DependencyProperty DenominationProperty =
            DependencyProperty.Register(
                "Denomiantion",
                typeof(Coins),
                typeof(CoinControl),
                new PropertyMetadata(Coins.Penny));

        /// <summary>
        /// The denomination this control displays and modifies
        /// </summary>
        public Coins Denomination
        {
            get { return (Coins)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }

        /// <summary>
        /// The dependency property for quantity
        /// </summary>
        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register(
                "Quantity",
                typeof(int),
                typeof(CoinControl),
                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        /// <summary>
        /// Gets or sets the quantity of coin
        /// </summary>
        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set { SetValue(QuantityProperty, value); }
        }

        public CoinControl()
        {
            InitializeComponent();
            IncreaseButton.Click += OnIncreaseClicked;
            DecreaseButton.Click += OnDecreaseClicked;
        }

        /// <summary>
        /// Event handler for increasing the number of coins
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnIncreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity++;
            QuantityChanged?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Event handler for decreasing the number of coins
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDecreaseClicked(object sender, RoutedEventArgs e)
        {
            if (Quantity > 0)
            {
                Quantity--;
                QuantityChanged?.Invoke(this, new EventArgs());
            }
        }
    }
}
