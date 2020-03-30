using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using System.ComponentModel;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class JerkedSodaPropertyChangedTests
    {
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var drink = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(drink);
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var drink = new JerkedSoda();
            Assert.PropertyChanged(drink, "Size", () =>
            {
                drink.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var drink = new JerkedSoda();
            Assert.PropertyChanged(drink, "Price", () =>
            {
                drink.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var drink = new JerkedSoda();
            Assert.PropertyChanged(drink, "Calories", () =>
            {
                drink.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var drink = new JerkedSoda();
            Assert.PropertyChanged(drink, "Ice", () =>
            {
                drink.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var drink = new JerkedSoda();
            Assert.PropertyChanged(drink, "SpecialInstructions", () =>
            {
                drink.Ice = false;
            });
        }

        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedForFlavor()
        {
            var drink = new JerkedSoda();
            Assert.PropertyChanged(drink, "Flavor", () =>
            {
                drink.Flavor = SodaFlavor.RootBeer;
            });
        }
    }
}
