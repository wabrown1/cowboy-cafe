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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        private OrderControl orderControl;

        public void OnDeleteItemButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                if (sender is Button button)
                {
                    if(button.DataContext is IOrderItem item)
                    {
                        o.Remove(item);
                    }
                }
            }
        }

        void OnListBoxItemSelected(object sender, SelectionChangedEventArgs args)
        {
            if(sender is ListBox lb)
            {
                if(lb.SelectedItem is IOrderItem orderItem)
                {
                    if(orderItem is AngryChicken ac)
                    {
                        var screen = new CustomizeAngryChicken();
                        screen.DataContext = ac;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (orderItem is CowboyCoffee c)
                    {
                        var screen = new CustomizeCowboyCoffee();
                        screen.DataContext = c;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (orderItem is CowpokeChili chili)
                    {
                        var screen = new CustomizeCowpokeChili();
                        screen.DataContext = chili;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (orderItem is DakotaDoubleBurger db)
                    {
                        var screen = new CustomizeDakotaDoubleBurger();
                        screen.DataContext = db;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (orderItem is JerkedSoda soda)
                    {
                        var screen = new CustomizeJerkedSoda();
                        screen.DataContext = soda;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (orderItem is PecosPulledPork pork)
                    {
                        var screen = new CustomizePecosPulledPork();
                        screen.DataContext = pork;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (orderItem is Side s)
                    {
                        var screen = new CustomizeSide();
                        screen.DataContext = s;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (orderItem is TexasTea t)
                    {
                        var screen = new CustomizeTexasTea();
                        screen.DataContext = t;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (orderItem is TexasTripleBurger triple)
                    {
                        var screen = new CustomizeTexasTripleBurger();
                        screen.DataContext = triple;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (orderItem is TrailBurger tb)
                    {
                        var screen = new CustomizeTrailBurger();
                        screen.DataContext = tb;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                    else if (orderItem is Water w)
                    {
                        var screen = new CustomizeWater();
                        screen.DataContext = w;
                        orderControl = this.FindAncestor<OrderControl>();
                        orderControl.SwapScreen(screen);
                    }
                }
            }
        }
    }
}
