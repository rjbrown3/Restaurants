using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurants.Models
{
    public class RestaurantTempStorage
    {
        private static List<Suggested> newSuggestions = new List<Suggested>();

        public static IEnumerable<Suggested> Suggestions => newSuggestions;

        public static void AddSuggestion(Suggested suggestion)
        {
            newSuggestions.Add(suggestion);
        }
    }
}
