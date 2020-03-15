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
    /// Interaction logic for CustomizeJerkedSoda.xaml
    /// </summary>
    public partial class CustomizeJerkedSoda : UserControl
    {
        public CustomizeJerkedSoda()
        {
            InitializeComponent();

            SmallButton.Click += OnSmallButtonClicked;
            MediumButton.Click += OnMediumButtonClicked;
            LargeButton.Click += OnLargeButtonClicked;

            CreamSodaButton.Click += OnCreamSodaButtonClicked;
            OrangeSodaButton.Click += OnOrangeSodaButtonClicked;
            SarsparillaButton.Click += OnSarsparillaButtonClicked;
            BirchBeerButton.Click += OnBirchBeerButtonClicked;
            RootBeerButton.Click += OnRootBeerButtonClicked;
        }

        public void OnSmallButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Drink drink)
            {
                drink.Size = CowboyCafe.Data.Size.Small;
            }
        }

        public void OnMediumButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Drink drink)
            {
                drink.Size = CowboyCafe.Data.Size.Medium;
            }
        }

        public void OnLargeButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Drink drink)
            {
                drink.Size = CowboyCafe.Data.Size.Large;
            }
        }

        public void OnCreamSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda drink)
            {
                drink.Flavor = CowboyCafe.Data.SodaFlavor.CreamSoda;
            }
        }

        public void OnOrangeSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda drink)
            {
                drink.Flavor = CowboyCafe.Data.SodaFlavor.OrangeSoda;
            }
        }

        public void OnSarsparillaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda drink)
            {
                drink.Flavor = CowboyCafe.Data.SodaFlavor.Sarsparilla;
            }
        }

        public void OnBirchBeerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda drink)
            {
                drink.Flavor = CowboyCafe.Data.SodaFlavor.BirchBeer;
            }
        }

        public void OnRootBeerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda drink)
            {
                drink.Flavor = CowboyCafe.Data.SodaFlavor.RootBeer;
            }
        }
    }
}
