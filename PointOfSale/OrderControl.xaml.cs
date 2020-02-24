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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Constructor to create event listeners for each button
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
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

        //Event listeners for each of the buttons in order control

        void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowpokeChili());
        }

        void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries());
        }
        void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new RustlersRibs());
        }

        void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PecosPulledPork());
        }

        void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TrailBurger());
        }

        void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new DakotaDoubleBurger());
        }

        void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTripleBurger());
        }

        void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new AngryChicken());
        }

        void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CornDodgers());
        }

        void OnAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PanDeCampo());
        }

        void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new BakedBeans());
        }

        void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new JerkedSoda());
        }

        void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTea());
        }

        void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowboyCoffee());
        }

        void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new Water());
        }
    }
}
