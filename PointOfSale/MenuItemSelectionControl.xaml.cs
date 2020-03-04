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
            if (DataContext is Order order)
            {
                order.Add(new ChiliCheeseFries());
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
            if (DataContext is Order order)
            {
                order.Add(new PecosPulledPork());
            }
        }

        void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new TrailBurger());
            if (DataContext is Order order)
            {
                order.Add(new TrailBurger());
            }
        }

        void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new DakotaDoubleBurger());
            if (DataContext is Order order)
            {
                order.Add(new DakotaDoubleBurger());
            }
        }

        void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new TexasTripleBurger());
            if (DataContext is Order order)
            {
                order.Add(new TexasTripleBurger());
            }
        }

        void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new AngryChicken());
            if (DataContext is Order order)
            {
                order.Add(new AngryChicken());
            }
        }

        void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new CornDodgers());
            if (DataContext is Order order)
            {
                order.Add(new CornDodgers());
            }
        }

        void OnAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new PanDeCampo());
            if (DataContext is Order order)
            {
                order.Add(new PanDeCampo());
            }
        }

        void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new BakedBeans());
            if (DataContext is Order order)
            {
                order.Add(new BakedBeans());
            }
        }

        void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new JerkedSoda());
            if (DataContext is Order order)
            {
                order.Add(new JerkedSoda());
            }
        }

        void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new TexasTea());
            if (DataContext is Order order)
            {
                order.Add(new TexasTea());
            }
        }

        void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new CowboyCoffee());
            if (DataContext is Order order)
            {
                order.Add(new CowboyCoffee());
            }
        }

        void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            //o.Add(new Water());
            if (DataContext is Order order)
            {
                order.Add(new Water());
            }
        }
    }
}
