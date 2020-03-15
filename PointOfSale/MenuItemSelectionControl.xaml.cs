/*
 * William Brown
 * MenuItemSelectionControl.xaml.cs
 * Class created event handlers for the user interface elements if the menu item selection control
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        private OrderControl orderControl;

        /// <summary>
        /// Constructor to create event handlers
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            
            //this.DataContext = o;
            AddCowpokeChili.Click += OnAddCowpokeChiliButtonClicked;
            AddRustlersRibs.Click += OnAddRustlersRibsButtonClicked;
            AddPecosPulledPork.Click += OnAddPecosPulledPorkButtonClicked;
            AddTrailBurger.Click += OnAddTrailBurgerButtonClicked;
            AddDakotaDoubleBurger.Click += OnAddDakotaDoubleBurgerButtonClicked;
            AddTexasTripleBurger.Click += OnAddTexasTripleBurgerButtonClicked;
            AddAngryChicken.Click += OnAddAngryChickenButtonClicked;
            AddChiliCheeseFries.Click += OnAddChiliCheeseFriesButtonClicked;
            AddCornDodgers.Click += OnAddCornDodgersButtonClicked;
            AddPanDeCampo.Click += OnAddPanDeCampoButtonClicked;
            AddBakedBeans.Click += OnAddBakedBeansButtonClicked;
            AddJerkedSoda.Click += OnAddJerkedSodaButtonClicked;
            AddTexasTea.Click += OnAddTexasTeaButtonClicked;
            AddCowboyCoffee.Click += OnAddCowboyCoffeeButtonClicked;
            AddWater.Click += OnAddWaterButtonClicked;
        }

        /*void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "CowpokeChili":
                            order.Add(new CowpokeChili);
                            break;
                    }
                }
            }
        }*/

        //Event listeners for each of the buttons in order control

        void AddItemAndOpenCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            var order = DataContext as Order;
            if (order == null) throw new Exception("Data context null, expected to be an order instance");

            if(screen != null)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("An ancetor of OrderControl ex");

                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }
            order.Add(item);
        }

        void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new CowpokeChili();
                var screen = new CustomizeCowpokeChili();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);
            }
            //o.Add(new CowpokeChili());
        }

        void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new ChiliCheeseFries());
            //o.Add(new ChiliCheeseFries());
            /*if (DataContext is Order order)
            {
                order.Add(new ChiliCheeseFries());
            }*/
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var side = new ChiliCheeseFries();
                var screen = new CustomizeSide();
                screen.DataContext = side;
                order.Add(side);
                orderControl.SwapScreen(screen);
            }
        }
        void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new RustlersRibs());
            if (DataContext is Order order)
            {
                order.Add(new RustlersRibs());
            }
        }

        void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new PecosPulledPork());
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new PecosPulledPork();
                var screen = new CustomizePecosPulledPork();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);
            }
        }

        void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new TrailBurger());
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new TrailBurger();
                var screen = new CustomizeTrailBurger();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);
            }
        }

        void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new DakotaDoubleBurger());
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new DakotaDoubleBurger();
                var screen = new CustomizeDakotaDoubleBurger();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);
            }
        }

        void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new TexasTripleBurger());
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new TexasTripleBurger();
                var screen = new CustomizeTexasTripleBurger();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);
            }
        }

        void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new AngryChicken());
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new AngryChicken();
                var screen = new CustomizeAngryChicken();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);
            }
        }

        void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new CornDodgers());
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var side = new CornDodgers();
                var screen = new CustomizeSide();
                screen.DataContext = side;
                order.Add(side);
                orderControl.SwapScreen(screen);
            }
        }

        void OnAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new PanDeCampo());
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var side = new PanDeCampo();
                var screen = new CustomizeSide();
                screen.DataContext = side;
                order.Add(side);
                orderControl.SwapScreen(screen);
            }
        }

        void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new BakedBeans());
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var side = new BakedBeans();
                var screen = new CustomizeSide();
                screen.DataContext = side;
                order.Add(side);
                orderControl.SwapScreen(screen);
            }
        }

        void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new JerkedSoda());
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var drink = new JerkedSoda();
                var screen = new CustomizeJerkedSoda();
                screen.DataContext = drink;
                order.Add(drink);
                orderControl.SwapScreen(screen);
            }
        }

        void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new TexasTea());
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var drink = new TexasTea();
                var screen = new CustomizeTexasTea();
                screen.DataContext = drink;
                order.Add(drink);
                orderControl.SwapScreen(screen);
            }
        }

        void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new CowboyCoffee());
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var drink = new CowboyCoffee();
                var screen = new CustomizeCowboyCoffee();
                screen.DataContext = drink;
                order.Add(drink);
                orderControl.SwapScreen(screen);
            }
        }

        void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new Water());
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var drink = new Water();
                var screen = new CustomizeWater();
                screen.DataContext = drink;
                order.Add(drink);
                orderControl.SwapScreen(screen);
            }
        }
    }
}
