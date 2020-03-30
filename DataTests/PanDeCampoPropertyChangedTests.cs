using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using System.ComponentModel;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class PanDeCampoPropertyChangedTests
    {
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var side = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(side);
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var side = new PanDeCampo();
            Assert.PropertyChanged(side, "Size", () =>
            {
                side.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var side = new PanDeCampo();
            Assert.PropertyChanged(side, "Price", () =>
            {
                side.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var side = new PanDeCampo();
            Assert.PropertyChanged(side, "Calories", () =>
            {
                side.Size = Size.Large;
            });
        }
    }
}
