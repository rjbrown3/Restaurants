using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurants.Models
{
    public class TopRestaurants
    {
        public TopRestaurants(int rank) // make rank read only
        {
            RestaurantRank = rank;
        }

        [Required]
        public int RestaurantRank { get; }
        [Required]
        public string RestaurantName { get; set; }
        public string? FavoriteDish { get; set; }
        [Required]
        public string Address { get; set; }
        public string? RestaurantPhone { get; set; }
        public string? WebsiteLink { get; set; } = "Coming soon."; // set default value

        public static TopRestaurants[] GetTopRestaurants()
        {
            TopRestaurants r1 = new TopRestaurants(1)
            {
                RestaurantName = "Slab Pizza",
                FavoriteDish = "Chicken Bacon Ranch",
                Address = "671 E 800 N, Provo, UT 84606",
                RestaurantPhone = "(801) 377-3883",
                WebsiteLink = "https://www.slabpizza.com/"
            };

            TopRestaurants r2 = new TopRestaurants(2)
            {
                RestaurantName = "Bok Bok Korean Fried Chicken",
                Address = "1181 N Canyon Rd, Provo, UT 84604",
                RestaurantPhone = "(801) 691-0921",
                WebsiteLink = "https://www.facebook.com/bokbokutah/"
            };

            TopRestaurants r3 = new TopRestaurants(3)
            {
                RestaurantName = "Station 22",
                FavoriteDish = null,
                Address = "22 W Center St, Provo, UT 84601",
                RestaurantPhone = "(801) 607-1803"
            };

            TopRestaurants r4 = new TopRestaurants(4)
            {
                RestaurantName = "KoKo Lunchbox",
                FavoriteDish = "Bulgogi",
                Address = "1175 N Canyon Rd #3420, Provo, UT 84604",
                RestaurantPhone = "(801) 850-4358",
                WebsiteLink = "https://m.facebook.com/kokobobox/"
            };

            TopRestaurants r5 = new TopRestaurants(5)
            {
                RestaurantName = "Bombay House",
                FavoriteDish = "Chicken Tikka Masala",
                Address = "463 N University Ave, Provo, UT 84601",
                RestaurantPhone = "(801) 373-6677"
            };

            return new TopRestaurants[] { r1, r2, r3, r4, r5 };
        }
    }    
}
