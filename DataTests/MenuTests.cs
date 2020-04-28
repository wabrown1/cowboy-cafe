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
            foreach (IOrderItem item in Menu.Sides())
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

        //Checks that only items that were searched for are returned by the Search method
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
            Assert.Equal(15, completeList.Count()); //all 15 menu items are added to the list

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

        //Checks that only the filtered menu item type is produced by the 
        //FilterByCategory method
        [Fact]
        public void FilterByCategoryTests()
        {
            IEnumerable<IOrderItem> entrees = Menu.Entrees();
            IEnumerable<IOrderItem> sides = Menu.Sides();
            IEnumerable<IOrderItem> drinks = Menu.Drinks();

            string[] ecategory = { "Entree" };
            string[] scategory = { "Side" };
            string[] dcategory = { "Drink" };

            var elist = Menu.FilterByCategory(entrees, ecategory);
            var slist = Menu.FilterByCategory(sides, scategory);
            var dlist = Menu.FilterByCategory(drinks, dcategory);

            foreach (IOrderItem item in elist)
            {
                Assert.IsAssignableFrom<Entree>(item);
            }
            foreach (IOrderItem item in slist)
            {
                Assert.IsAssignableFrom<Side>(item);
            }
            foreach (IOrderItem item in dlist)
            {
                Assert.IsAssignableFrom<Drink>(item);
            }

            string[] ncategory = { "" };
            var nlist = Menu.FilterByCategory(Menu.All, ncategory);
            Assert.Empty(nlist); //no menu items are added when searching for an empty category
        }

        //Checks that only menu items that fall within a given calorie range are returned
        //by the FilterByCalories method
        [Fact]
        public void FilterByCaloriesTest()
        {
            IEnumerable<IOrderItem> allList = Menu.FilterByCalories(Menu.All, null, null);
            Assert.Equal(15, allList.Count());

            //water is the only menu item with zero calories
            IEnumerable<IOrderItem> zeroMaxList = Menu.FilterByCalories(Menu.All, null, 0);
            foreach (IOrderItem item in zeroMaxList)
            {
                Assert.IsType<Water>(item);
            }
            Assert.Single(zeroMaxList);

            IEnumerable<IOrderItem> highMinList = Menu.FilterByCalories(Menu.All, 1000, null);
            Assert.Empty(highMinList);

            IEnumerable<IOrderItem> AngryChickenList = Menu.FilterByCalories(Menu.All, 190, 190);
            foreach(IOrderItem item in AngryChickenList)
            {
                Assert.IsAssignableFrom<AngryChicken>(item);
            }
            Assert.Single(AngryChickenList);
        }

        //Checks that only menu items the are within the given price range are returned
        //by the FilterByPrice method
        [Fact]
        public void FilterByPriceTest()
        {
            IEnumerable<IOrderItem> allList = Menu.FilterByPrice(Menu.All, null, null);
            Assert.Equal(15, allList.Count());

            IEnumerable<IOrderItem> zeroList = Menu.FilterByPrice(Menu.All, null, 0);
            Assert.Empty(zeroList);

            IEnumerable<IOrderItem> highMinPriceList = Menu.FilterByPrice(Menu.All, 10, null);
            Assert.Empty(highMinPriceList);

            IEnumerable<IOrderItem> angryChickenList = Menu.FilterByPrice(Menu.All, 5.99, 5.99);
            foreach (IOrderItem item in angryChickenList)
            {
                Assert.IsAssignableFrom<AngryChicken>(item);
            }
            Assert.Single(angryChickenList);
        }
    }
}
