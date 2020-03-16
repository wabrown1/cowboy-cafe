/*
 * William Brown
 * CustomizeSida.cs
 * Class to define behavior of buttons in the CustomizeSide interface
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
    /// Interaction logic for CustomizeSide.xaml
    /// </summary>
    public partial class CustomizeSide : UserControl
    {
        public CustomizeSide()
        {
            InitializeComponent();
            //SmallButton.IsChecked = true;

            SmallButton.Click += OnSmallButtonClicked;
            MediumButton.Click += OnMediumButtonClicked;
            LargeButton.Click += OnLargeButtonClicked;
        }

        //Event handlers for selecting a different size side
        public void OnSmallButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Side side)
            {
                side.Size = CowboyCafe.Data.Size.Small;
            }
        }

        public void OnMediumButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Side side)
            {
                side.Size = CowboyCafe.Data.Size.Medium;
            }
        }

        public void OnLargeButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Side side)
            {
                side.Size = CowboyCafe.Data.Size.Large;
            }
        }
    }
}
