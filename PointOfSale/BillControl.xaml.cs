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
using System.ComponentModel;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for BillControl.xaml
    /// </summary>
    public partial class BillControl : UserControl
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
                typeof(Bills),
                typeof(BillControl),
                new PropertyMetadata(Bills.One));

        /// <summary>
        /// The denomination this control displays and modifies
        /// </summary>
        public Bills Denomination
        {
            get { return (Bills)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }

        /// <summary>
        /// The dependency property for quantity
        /// </summary>
        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register(
                "Quantity",
                typeof(int),
                typeof(BillControl),
                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        /// <summary>
        /// Gets or sets the quantity of coin
        /// </summary>
        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set { SetValue(QuantityProperty, value); }
        }

        public void OnIncreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity++;
            QuantityChanged?.Invoke(this, new EventArgs());
        }

        public void OnDecreaseClicked(object sender, RoutedEventArgs e)
        {
            if(Quantity > 0)
            {
                Quantity--;
                QuantityChanged?.Invoke(this, new EventArgs());
            }
        }

        public BillControl()
        {
            InitializeComponent();
            IncreaseButton.Click += OnIncreaseClicked;
            DecreaseButton.Click += OnDecreaseClicked;
        }
    }
}
