using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Gets and sets the search terms
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; } = "";

        public IEnumerable<IOrderItem> Entrees { get; set; } = Menu.Entrees();

        public IEnumerable<IOrderItem> Sides { get; set; } = Menu.Sides();

        public IEnumerable<IOrderItem> Drinks { get; set; } = Menu.Drinks();

        /// <summary>
        /// List of the possible categories for items
        /// </summary>
        public string[] CategoriesList { get { return new string[] { "Entree", "Side", "Drink" }; } }

        /// <summary>
        /// Stores the selected categories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string[] Categories { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? CaloriesMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? CaloriesMax { get; set; }

        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; }

        //public string[] Catagories

        public void OnGet(/*int? CaloriesMin, int? CaloriesMax, double? PriceMin, double? PriceMax*/)
        {
            /*this.PriceMax = PriceMax;
            this.PriceMin = PriceMin;
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;

            Entrees = Menu.Search(Entrees, SearchTerms);
            Sides = Menu.Search(Sides, SearchTerms);
            Drinks = Menu.Search(Drinks, SearchTerms);

            Entrees = Menu.FilterByCalories(Entrees, CaloriesMin, CaloriesMax);
            Sides = Menu.FilterByCalories(Sides, CaloriesMin, CaloriesMax);
            Drinks = Menu.FilterByCalories(Drinks, CaloriesMin, CaloriesMax);

            Entrees = Menu.FilterByPrice(Entrees, PriceMin, PriceMax);
            Sides = Menu.FilterByPrice(Sides, PriceMin, PriceMax);
            Drinks = Menu.FilterByPrice(Drinks, PriceMin, PriceMax);*/
        }

        public void OnPost()
        {
            Entrees = Menu.Search(Entrees, SearchTerms);
            Sides = Menu.Search(Sides, SearchTerms);
            Drinks = Menu.Search(Drinks, SearchTerms);

            Entrees = Menu.FilterByCalories(Entrees, CaloriesMin, CaloriesMax);
            Sides = Menu.FilterByCalories(Sides, CaloriesMin, CaloriesMax);
            Drinks = Menu.FilterByCalories(Drinks, CaloriesMin, CaloriesMax);

            Entrees = Menu.FilterByPrice(Entrees, PriceMin, PriceMax);
            Sides = Menu.FilterByPrice(Sides, PriceMin, PriceMax);
            Drinks = Menu.FilterByPrice(Drinks, PriceMin, PriceMax);

            Entrees = Menu.FilterByCategory(Entrees, Categories);
            Sides = Menu.FilterByCategory(Sides, Categories);
            Drinks = Menu.FilterByCategory(Drinks, Categories);
        }
    }
}
