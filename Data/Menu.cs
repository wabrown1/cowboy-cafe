/*
 * William Brown
 * Menu.cs
 * Creates lists for each type of menu item for use in
 * diplay on the web page
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// Returns a list containing one of each entree
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new AngryChicken());
            entrees.Add(new CowpokeChili());
            entrees.Add(new RustlersRibs());
            entrees.Add(new PecosPulledPork());
            entrees.Add(new TrailBurger());
            entrees.Add(new DakotaDoubleBurger());
            entrees.Add(new TexasTripleBurger());

            return entrees;
        }

        /// <summary>
        /// Returns a list containing one of each side
        /// </summary>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            sides.Add(new ChiliCheeseFries());
            sides.Add(new CornDodgers());
            sides.Add(new PanDeCampo());
            sides.Add(new BakedBeans());

            return sides;
        }

        /// <summary>
        /// Returns a list containing one of each drink
        /// </summary>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            drinks.Add(new TexasTea());
            drinks.Add(new CowboyCoffee());
            drinks.Add(new JerkedSoda());
            drinks.Add(new Water());

            return drinks;
        }

        /// <summary>
        /// Returns a list containing one of each IORderItem
        /// </summary>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> menuItems = new List<IOrderItem>();
            menuItems.Add(new AngryChicken());
            menuItems.Add(new CowpokeChili());
            menuItems.Add(new RustlersRibs());
            menuItems.Add(new PecosPulledPork());
            menuItems.Add(new TrailBurger());
            menuItems.Add(new DakotaDoubleBurger());
            menuItems.Add(new TexasTripleBurger());

            menuItems.Add(new ChiliCheeseFries());
            menuItems.Add(new CornDodgers());
            menuItems.Add(new PanDeCampo());
            menuItems.Add(new BakedBeans());

            menuItems.Add(new TexasTea());
            menuItems.Add(new CowboyCoffee());
            menuItems.Add(new JerkedSoda());
            menuItems.Add(new Water());

            return menuItems;
        }
    }
}
