/*
 * William Brown
 * Menu.cs
 * Creates lists for each type of menu item for use in
 * diplay on the web page
 */

using System;
using System.Collections.Generic;
using System.Linq;
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
        /// Returns a list containing one of each IOrderItem
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

        /// <summary>
        /// Returns all menu items
        /// </summary>
        public static IEnumerable<IOrderItem> All { get { return CompleteMenu(); } }

        /// <summary>
        /// Filters the given order items based to match the given terms
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <param name="orderItems">The items that will be filtered</param>
        /// <returns>A collection of IOrderItems</returns>
        ///
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> orderItems, string terms)
        {
            // TODO: Search database
            List<IOrderItem> results = new List<IOrderItem>();

            // Return all menu items if there are no search terms
            if (terms == null) return orderItems;

            // return each item in the menu containing the terms substring
            foreach (IOrderItem item in orderItems)
            {
                if (item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the given list of order items to only include items from the given categories
        /// </summary>
        /// <param name="items">The possible order items</param>
        /// <param name="categories">The categories that the order items must match</param>
        /// <returns>A filtered list of IOrderedItems</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> categories)
        {
            // TODO: Filter the list
            // If no filter is specified, just return the provided collection
            if (categories == null || categories.Count() == 0) return items;

            // Filter the supplied collection of menu items
            List<IOrderItem> results = new List<IOrderItem>();

            foreach (IOrderItem item in items)
            {
                if (item.GetType().BaseType == typeof(Entree) && categories.Contains("Entree"))
                {
                    results.Add(item);
                }
                else if (item.GetType().BaseType == typeof(Side) && categories.Contains("Side"))
                {
                    results.Add(item);
                }
                else if (item.GetType().BaseType == typeof(Drink) && categories.Contains("Drink"))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the given order items to be in the given calories range
        /// </summary>
        /// <param name="orderItems">The order items that will be filtered</param>
        /// <param name="min">The minimum calories</param>
        /// <param name="max">The maximum calories</param>
        /// <returns>A filtered list of IOrderedItems</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> orderItems, int? min, int? max)
        {
            // TODO: Filter menu items
            if (min == null && max == null) return orderItems;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in orderItems)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the given order items to be within the given price range
        /// </summary>
        /// <param name="orderItems">The list of IOrderItems to be filtered</param>
        /// <param name="min">The minimum price</param>
        /// <param name="max">The maximum price</param>
        /// <returns>A filtered list of IOrderedItems</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> orderItems, double? min, double? max)
        {
            // TODO: Filter menu items
            if (min == null && max == null) return orderItems;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in orderItems)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
