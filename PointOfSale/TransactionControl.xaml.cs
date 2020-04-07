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
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        public TransactionControl()
        {
            InitializeComponent();

            CreditButton.Click += OnCreditButtonClicked;
            CashButton.Click += OnCashButtonClicked;
            cashPayControl.TotalChanged += OnTotalChanged;
        }

        private double tax;
        /// <summary>
        /// The tax of the order
        /// </summary>
        public double Tax
        {
            get
            {
                if (DataContext is Order o)
                {
                    tax = Math.Round(o.Subtotal * 0.16, 2);
                }

                return tax;
            }
        }

        private double total;
        /// <summary>
        /// The total cost of the order
        /// </summary>
        public double Total
        {
            get
            {
                if (DataContext is Order o)
                {
                    total = Math.Round(o.Subtotal + Tax, 2);
                }
                return total;
            }
        }

        /// <summary>
        /// click event for the credit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCreditButtonClicked(object sender, RoutedEventArgs e)
        {
            var ct = new CardTerminal();

            var result = ct.ProcessTransaction(0);

            var orderControl = ExtensionMethods.FindAncestor<OrderControl>(this);           

            if (result == ResultCode.Success)
            {
                MessageBox.Show("Printing receipt");
                string CreditReceipt = MakeReceipt() + "\nCREDIT\n";
                var receiptPrinter = new ReceiptPrinter();
                receiptPrinter.Print(CreditReceipt);

                orderControl.DataContext = new Order();
                orderControl.SwapScreen(new MenuItemSelectionControl());
            }
            else
            {
                MessageBox.Show(string.Format("{0}", result.ToString()));
                orderControl.SwapScreen(new TransactionControl());
            }
        }

        /// <summary>
        /// Enables cash payment selection when the cash payment button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCashButtonClicked(object sender, RoutedEventArgs e)
        {
            CashPayBorder.IsEnabled = true;
        }

        /// <summary>
        /// Method to create a string representing the receipt for the current order.
        /// </summary>
        /// <returns>A string with the order number, date/time, items ordered, subtotal, tax, and total, each on thier own line. </returns>
        public string MakeReceipt()
        {
            string receipt = "\n";

            if (DataContext is Order order)
            {
                receipt += string.Format("Order {0}\n", order.OrderNumber);
                receipt += DateTime.Now.ToString() + '\n';
                foreach (IOrderItem item in order.Items)
                {
                    receipt += string.Format("{0}\t{1:C}\n", item.ToString(), item.Price);
                    foreach (string instruction in item.SpecialInstructions)
                    {
                        receipt += (string.Format("\t{0}\n", instruction));
                    }
                }
                receipt += string.Format("Subtotal: {0:C}\n Total: {1:C}\n", order.Subtotal, Total);
            }

            return receipt;
        }

        /// <summary>
        /// method to calculate the changed needed when cash is submitted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnTotalChanged(object sender, EventArgs e)
        {
            double change = 0;
            if (sender is CashPayControl cpc)
            {
                if (DataContext is Order o)
                {
                    change = Math.Round(cpc.CashPaid - Total, 2);
                }

                if (change > 0)
                {
                    MessageBox.Show(CalculateChange(change));
                    MessageBox.Show("Printing receipt");
                    string CreditReceipt = MakeReceipt() + string.Format("\nCASH GIVEN: {0:C}\nCHANGE:\t{1:C}\n", cpc.CashPaid, -change);
                    var receiptPrinter = new ReceiptPrinter();
                    receiptPrinter.Print(CreditReceipt);

                    var orderControl = ExtensionMethods.FindAncestor<OrderControl>(this);
                    orderControl.DataContext = new Order();
                    orderControl.SwapScreen(new MenuItemSelectionControl());
                }
            }
        }

        /// <summary>
        /// Method to calculate which bills and /or coins to give to return proper change
        /// and adjusts the contents of the register accordingly
        /// </summary>
        /// <param name="changeToReturn">The change to give, will be calculated in terms
        /// of numbers of bills and coins</param>
        /// <returns></returns>
        public string CalculateChange(double changeToReturn)
        {
            string change = "Change to return: ";

            if(changeToReturn >= 100 && OrderControl.CashDrawer.Hundreds > 0)
            {
                int numBills = 0;
                while(changeToReturn >= 100 && OrderControl.CashDrawer.Hundreds > 0)
                {
                    numBills++;
                    changeToReturn -= 100;
                    OrderControl.CashDrawer.RemoveBill(Bills.Hundred, 1);
                }
                change += string.Format("/n%d Hundreds/n", numBills);
            }
            if (changeToReturn >= 50 && OrderControl.CashDrawer.Fifties > 0)
            {
                int numBills = 0;
                while (changeToReturn >= 50 && OrderControl.CashDrawer.Fifties > 0)
                {
                    numBills++;
                    changeToReturn -= 50;
                    OrderControl.CashDrawer.RemoveBill(Bills.Fifty, 1);
                }
                change += string.Format("/n%d Fifties/n", numBills);
            }
            if (changeToReturn >= 20 && OrderControl.CashDrawer.Twenties > 0)
            {
                int numBills = 0;
                while (changeToReturn >= 20 && OrderControl.CashDrawer.Twenties > 0)
                {
                    numBills++;
                    changeToReturn -= 100;
                    OrderControl.CashDrawer.RemoveBill(Bills.Twenty, 1);
                }
                change += string.Format("/n%d Twenties/n", numBills);
            }
            if (changeToReturn >= 10 && OrderControl.CashDrawer.Tens > 0)
            {
                int numBills = 0;
                while (changeToReturn >= 10 && OrderControl.CashDrawer.Tens > 0)
                {
                    numBills++;
                    changeToReturn -= 10;
                    OrderControl.CashDrawer.RemoveBill(Bills.Ten, 1);
                }
                change += string.Format("/n%d Tens/n", numBills);
            }
            if (changeToReturn >= 5 && OrderControl.CashDrawer.Fives > 0)
            {
                int numBills = 0;
                while (changeToReturn >= 5 && OrderControl.CashDrawer.Fives > 0)
                {
                    numBills++;
                    changeToReturn -= 5;
                    OrderControl.CashDrawer.RemoveBill(Bills.Five, 1);
                }
                change += string.Format("/n%d Fives/n", numBills);
            }
            if (changeToReturn >= 2 && OrderControl.CashDrawer.Twos > 0)
            {
                int numBills = 0;
                while (changeToReturn >= 2 && OrderControl.CashDrawer.Twos > 0)
                {
                    numBills++;
                    changeToReturn -= 2;
                    OrderControl.CashDrawer.RemoveBill(Bills.Two, 1);
                }
                change += string.Format("/n%d Twos/n", numBills);
            }
            if (changeToReturn >= 1 && OrderControl.CashDrawer.Ones > 0)
            {
                int numBills = 0;
                while (changeToReturn >= 1 && OrderControl.CashDrawer.Ones > 0)
                {
                    numBills++;
                    changeToReturn -= 1;
                    OrderControl.CashDrawer.RemoveBill(Bills.One, 1);
                }
                change += string.Format("/n%d Ones/n", numBills);
            }
            if (changeToReturn >= 1 && OrderControl.CashDrawer.Dollars > 0)
            {
                int numCoins = 0;
                while (changeToReturn >= 1 && OrderControl.CashDrawer.Dollars > 0)
                {
                    numCoins++;
                    changeToReturn -= 1;
                    OrderControl.CashDrawer.RemoveCoin(Coins.Dollar, 1);
                }
                change += string.Format("/n%d Dollar coins/n", numCoins);
            }
            if (changeToReturn >= .5 && OrderControl.CashDrawer.HalfDollars > 0)
            {
                int numCoins = 0;
                while (changeToReturn >= .5 && OrderControl.CashDrawer.HalfDollars > 0)
                {
                    numCoins++;
                    changeToReturn -= .5;
                    OrderControl.CashDrawer.RemoveCoin(Coins.HalfDollar, 1);
                }
                change += string.Format("/n%d Half dollars/n", numCoins);
            }
            if (changeToReturn >= .25 && OrderControl.CashDrawer.Quarters > 0)
            {
                int numCoins = 0;
                while (changeToReturn >= .25 && OrderControl.CashDrawer.Quarters > 0)
                {
                    numCoins++;
                    changeToReturn -= .25;
                    OrderControl.CashDrawer.RemoveCoin(Coins.Quarter, 1);
                }
                change += string.Format("/n%d Quarters/n", numCoins);
            }
            if (changeToReturn >= .1 && OrderControl.CashDrawer.Dimes > 0)
            {
                int numCoins = 0;
                while (changeToReturn >= .1 && OrderControl.CashDrawer.Dimes > 0)
                {
                    numCoins++;
                    changeToReturn -= .1;
                    OrderControl.CashDrawer.RemoveCoin(Coins.Dime, 1);
                }
                change += string.Format("/n%d Dimes/n", numCoins);
            }
            if (changeToReturn >= .05 && OrderControl.CashDrawer.Nickels > 0)
            {
                int numCoins = 0;
                while (changeToReturn >= .05 && OrderControl.CashDrawer.Nickels > 0)
                {
                    numCoins++;
                    changeToReturn -= .05;
                    OrderControl.CashDrawer.RemoveCoin(Coins.Nickel, 1);
                }
                change += string.Format("/n%d Nickel/n", numCoins);
            }
            if (changeToReturn >= .01 && OrderControl.CashDrawer.Pennies > 0)
            {
                int numCoins = 0;
                while (changeToReturn >= .01 && OrderControl.CashDrawer.Pennies > 0)
                {
                    numCoins++;
                    changeToReturn -= .01;
                    OrderControl.CashDrawer.RemoveCoin(Coins.Penny, 1);
                }
                change += string.Format("/n%d Pennies/n", numCoins);
            }
            if(changeToReturn != 0)
            {
                return "Not enough money in register to give proper change";
            }
            else
            {
                return change;
            }
        }
    }
}
