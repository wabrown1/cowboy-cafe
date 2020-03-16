/*
 * William Brown
 * CustomizeCowboyCoffee.cs
 * Class to define behavior of buttons in the CowboyCoffee interface
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
    /// Interaction logic for CustomizeCowboyCoffee.xaml
    /// </summary>
    public partial class CustomizeCowboyCoffee : UserControl
    {
        public CustomizeCowboyCoffee()
        {
            InitializeComponent();

            SmallButton.Click += OnSmallButtonClicked;
            MediumButton.Click += OnMediumButtonClicked;
            LargeButton.Click += OnLargeButtonClicked;
        }

        //Event handlers for the buttons in the user control
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
    }
}
