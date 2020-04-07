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
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPayControl.xaml
    /// </summary>
    public partial class CashPayControl : UserControl
    {
        public CashPayControl()
        {
            InitializeComponent();
            PennyControl.QuantityChanged += OnQuantityChanged;
            NickelControl.QuantityChanged += OnQuantityChanged;
            DimeControl.QuantityChanged += OnQuantityChanged;
            QuarterControl.QuantityChanged += OnQuantityChanged;
            HalfDollarControl.QuantityChanged += OnQuantityChanged;
            DollarControl.QuantityChanged += OnQuantityChanged;
            OneControl.QuantityChanged += OnQuantityChanged;
            TwoControl.QuantityChanged += OnQuantityChanged;
            FiveControl.QuantityChanged += OnQuantityChanged;
            TenControl.QuantityChanged += OnQuantityChanged;
            TwentyControl.QuantityChanged += OnQuantityChanged;
            FiftyControl.QuantityChanged += OnQuantityChanged;
            HundredControl.QuantityChanged += OnQuantityChanged;

            SubmitButton.Click += OnSubmitButtonClicked;
            SubmitButton.Click += OnQuantityChanged;
        }

        /// <summary>
        /// Event to be thrown when the total cash paid is changed
        /// </summary>
        public event EventHandler TotalChanged;

        public static readonly DependencyProperty CashPaidProperty = DependencyProperty.Register(
            "CashPaid",
            typeof(double),
            typeof(CashPayControl),
            new PropertyMetadata()
            );

        /// <summary>
        /// The cash paid by the customer
        /// </summary>
        public double CashPaid
        {
            get { return (double)GetValue(CashPaidProperty); }
            set { SetValue(CashPaidProperty, value); }
        }

        /// <summary>
        /// Event handler for when the quantity of bills or coins paid changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnQuantityChanged(object sender, EventArgs e)
        {
            CashPaid = 0;

            foreach (object obj in CurrencyGrid.Children)
            {
                if (obj is CoinControl c)
                {
                    switch (c.Denomination)
                    {
                        case Coins.Penny:
                            CashPaid += 0.01 * c.Quantity;
                            break;
                        case Coins.Nickel:
                            CashPaid += 0.05 * c.Quantity;
                            break;
                        case Coins.Dime:
                            CashPaid += 0.10 * c.Quantity;
                            break;
                        case Coins.Quarter:
                            CashPaid += 0.25 * c.Quantity;
                            break;
                        case Coins.HalfDollar:
                            CashPaid += 0.50 * c.Quantity;
                            break;
                        case Coins.Dollar:
                            CashPaid += 1.00 * c.Quantity;
                            break;
                    }
                }
                else if (obj is BillControl b)
                {
                    switch (b.Denomination)
                    {
                        case Bills.One:
                            CashPaid += 1.00 * b.Quantity;
                            break;
                        case Bills.Two:
                            CashPaid += 2.00 * b.Quantity;
                            break;
                        case Bills.Five:
                            CashPaid += 5.00 * b.Quantity;
                            break;
                        case Bills.Ten:
                            CashPaid += 10.00 * b.Quantity;
                            break;
                        case Bills.Twenty:
                            CashPaid += 20.00 * b.Quantity;
                            break;
                        case Bills.Fifty:
                            CashPaid += 50.00 * b.Quantity;
                            break;
                        case Bills.Hundred:
                            CashPaid += 100.00 * b.Quantity;
                            break;
                    }
                }
            }
            //Allows payment to be completed if enough cash is paid
            if (DataContext is Order order)
            {
                if (CashPaid >= Math.Round(order.Subtotal * 1.16, 2))
                {
                    SubmitButton.IsEnabled = true;
                }
            }
        }

        /// <summary>
        /// Event handler for when the user submits the payment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            {
                TotalChanged?.Invoke(this, new EventArgs());

                foreach (object obj in CurrencyGrid.Children)
                {
                    if (obj is CoinControl c)
                    {
                        switch (c.Denomination)
                        {
                            case Coins.Penny:
                                OrderControl.CashDrawer.AddCoin(CashRegister.Coins.Penny, c.Quantity);
                                c.Quantity = 0;
                                break;
                            case Coins.Nickel:
                                OrderControl.CashDrawer.AddCoin(CashRegister.Coins.Nickel, c.Quantity);
                                c.Quantity = 0;
                                break;
                            case Coins.Dime:
                                OrderControl.CashDrawer.AddCoin(CashRegister.Coins.Dime, c.Quantity);
                                c.Quantity = 0;
                                break;
                            case Coins.Quarter:
                                OrderControl.CashDrawer.AddCoin(CashRegister.Coins.Quarter, c.Quantity);
                                c.Quantity = 0;
                                break;
                            case Coins.HalfDollar:
                                OrderControl.CashDrawer.AddCoin(CashRegister.Coins.HalfDollar, c.Quantity);
                                c.Quantity = 0;
                                break;
                            case Coins.Dollar:
                                OrderControl.CashDrawer.AddCoin(CashRegister.Coins.Dollar, c.Quantity);
                                c.Quantity = 0;
                                break;
                        }
                    }
                    else if (obj is BillControl b)
                    {
                        switch (b.Denomination)
                        {
                            case Bills.One:
                                OrderControl.CashDrawer.AddBill(CashRegister.Bills.One, b.Quantity);
                                b.Quantity = 0;
                                break;
                            case Bills.Two:
                                OrderControl.CashDrawer.AddBill(CashRegister.Bills.Two, b.Quantity);
                                b.Quantity = 0;
                                break;
                            case Bills.Five:
                                OrderControl.CashDrawer.AddBill(CashRegister.Bills.Five, b.Quantity);
                                b.Quantity = 0;
                                break;
                            case Bills.Ten:
                                OrderControl.CashDrawer.AddBill(CashRegister.Bills.Ten, b.Quantity);
                                b.Quantity = 0;
                                break;
                            case Bills.Twenty:
                                OrderControl.CashDrawer.AddBill(CashRegister.Bills.Twenty, b.Quantity);
                                b.Quantity = 0;
                                break;
                            case Bills.Fifty:
                                OrderControl.CashDrawer.AddBill(CashRegister.Bills.Fifty, b.Quantity);
                                b.Quantity = 0;
                                break;
                            case Bills.Hundred:
                                OrderControl.CashDrawer.AddBill(CashRegister.Bills.Hundred, b.Quantity);
                                b.Quantity = 0;
                                break;
                        }
                    }
                }
            }
        }
    }
}
