using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class MenuTests
    {
        [Theory]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(PanDeCampo))]
        public void SidesShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach(IOrderItem item in Menu.Sides())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        [Fact]
        public void SidesShouldOnlyHaveFourItems()
        {
            Assert.Equal(4, Menu.Sides().Count());
        }

        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        public void EntreesShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Entrees())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        [Fact]
        public void EntreesShouldOnlyHaveSevenItems()
        {
            Assert.Equal(7, Menu.Entrees().Count());
        }

        [Theory]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(Water))]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(JerkedSoda))]
        public void DrinksShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Drinks())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        [Fact]
        public void DrinksShouldOnlyHaveFourItems()
        {
            Assert.Equal(4, Menu.Drinks().Count());
        }

        [Theory]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(Water))]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        public void AllHasAnInstanceOfEveryMenuItem(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.All)
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        [Fact]
        public void AllHasOnlyFifteenItems()
        {
            Assert.Equal(15, Menu.All.Count());
        }

        [Fact]
        public void SearchShouldReturnOnlySearchedItems()
        {
            IEnumerable<IOrderItem> entrees = Menu.Entrees();
            IEnumerable<IOrderItem> sides = Menu.Sides();
            IEnumerable<IOrderItem> drinks = Menu.Drinks();

            string eterms = "Angry Chicken";
            string sterms = "Corn Dodgers";
            string dterms = "Water";
            
            IEnumerable<IOrderItem> entreeItems = Menu.Search(entrees, eterms);
            IEnumerable<IOrderItem> sideItems = Menu.Search(sides, sterms);
            IEnumerable<IOrderItem> drinkItems = Menu.Search(drinks, dterms);

            var menuItems = entreeItems.Concat(sideItems).Concat(drinkItems);

            var types = new List<Type>();
            foreach (IOrderItem item in menuItems)
            {
                types.Add(item.GetType());
            }
            Assert.Contains(typeof(AngryChicken), types);
            Assert.Contains(typeof(Water), types);
            Assert.Contains(typeof(CornDodgers), types);

            Assert.Single(entreeItems);
            Assert.Single(drinkItems);
            Assert.Single(sideItems);

            string nullTerms = "";
            IEnumerable<IOrderItem> completeList = Menu.Search(Menu.All, nullTerms);
            Assert.Equal(15, completeList.Count());

            /*var ntypes = new List<Type>();
            foreach (IOrderItem item in completeList)
            {
                ntypes.Add(item.GetType());
            }
            foreach(IOrderItem item in Menu.All)
            {
                Assert.Contains(typeof(item), ntypes);
            }*/
        }
    }
}
