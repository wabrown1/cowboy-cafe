/*
 * William Brown
 * CustomizeJerkedSoda.cs
 * Class to define behavior of buttons in the CustomizeJerkedSoda interface
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
using Size = CowboyCafe.Data.Size;

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

        /// <summary>
        /// Selects the correct button when returning to the item customization
        /// </summary>
        public void SetButton()
        {
            Size s;
            if (DataContext is Drink)
            {
                Drink d = (Drink)DataContext;
                s = d.Size;
            }
            else
            {
                throw new NotImplementedException("Should never be reached");
            }

            switch (s)
            {
                case Size.Small:
                    SmallButton.IsChecked = true;
                    break;
                case Size.Medium:
                    MediumButton.IsChecked = true;
                    break;
                case Size.Large:
                    LargeButton.IsChecked = true;
                    break;
                default:
                    throw new NotImplementedException("Should never be reached");
            }
        }

        public void SetFlavorButton()
        {
            if (DataContext is JerkedSoda drink)
            {
                switch (drink.Flavor)
                {
                    case SodaFlavor.BirchBeer:
                        BirchBeerButton.IsChecked = true;
                        break;
                    case SodaFlavor.CreamSoda:
                        CreamSodaButton.IsChecked = true;
                        break;
                    case SodaFlavor.OrangeSoda:
                        OrangeSodaButton.IsChecked = true;
                        break;
                    case SodaFlavor.RootBeer:
                        RootBeerButton.IsChecked = true;
                        break;
                    case SodaFlavor.Sarsparilla:
                        SarsparillaButton.IsChecked = true;
                        break;
                    default:
                        throw new NotImplementedException("Should never be reached");
                }
            }
        }

        //Event handlers for selecting a size of flavor
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
