using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurants.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> TopRestaurantList = new List<string>();

            foreach (TopRestaurants tr in TopRestaurants.GetTopRestaurants())
            {
                #nullable enable
                string? favDish = tr.FavoriteDish ?? "It's all tasty!";         // if favorite dish is null, set to "It's all tasty!"

                TopRestaurantList.Add($"#{tr.RestaurantRank}: {tr.RestaurantName} \n " +
                    $"Favorite Dish: {favDish} \n " +
                    $"Address: {tr.Address} Phone: {tr.RestaurantPhone} \n " +
                    $"Website: {tr.WebsiteLink}");
            }

            return View(TopRestaurantList);
        }

        [HttpGet]
        public IActionResult SuggestRestaurants()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SuggestRestaurants(Suggested newSuggestion)
        {
            if (ModelState.IsValid)                 // if the model is valid add new suggestion to the temp storage and return new view
            {
                RestaurantTempStorage.AddSuggestion(newSuggestion);
                return View("ListSuggestions", RestaurantTempStorage.Suggestions);
            }
            else
            {
                return View();                      // if model is unvalid, stay on the page with the displayed error messages
            }
        }

        public IActionResult ListSuggestions()
        {
            return View(RestaurantTempStorage.Suggestions);    // pass the temporary list of user suggestions to the view
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
