using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using System.ComponentModel;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class CowboyCoffeePropertyChangedTests
    {
        [Fact]
        public void CowboyCoffeeShouldImplementINotifyPropertyChanged()
        {
            var drink = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(drink);
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var drink = new CowboyCoffee();
            Assert.PropertyChanged(drink, "Size", () =>
            {
                drink.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var drink = new CowboyCoffee();
            Assert.PropertyChanged(drink, "Price", () =>
            {
                drink.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var drink = new CowboyCoffee();
            Assert.PropertyChanged(drink, "Calories", () =>
            {
                drink.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var drink = new CowboyCoffee();
            Assert.PropertyChanged(drink, "Ice", () =>
            {
                drink.Ice = true;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var drink = new CowboyCoffee();
            Assert.PropertyChanged(drink, "SpecialInstructions", () =>
            {
                drink.Ice = true;
            });
        }

        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForDecaf()
        {
            var drink = new CowboyCoffee();
            Assert.PropertyChanged(drink, "Decaf", () =>
            {
                drink.Decaf = true;
            });
        }

        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForSpecialInstructions()
        {
            var drink = new CowboyCoffee();
            Assert.PropertyChanged(drink, "SpecialInstructions", () =>
            {
                drink.Decaf = true;
            });
        }

        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedRoomForCream()
        {
            var drink = new CowboyCoffee();
            Assert.PropertyChanged(drink, "RoomForCream", () =>
            {
                drink.RoomForCream = true;
            });
        }

        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedSpecialInstructions()
        {
            var drink = new CowboyCoffee();
            Assert.PropertyChanged(drink, "SpecialInstructions", () =>
            {
                drink.RoomForCream = true;
            });
        }
    }
}
