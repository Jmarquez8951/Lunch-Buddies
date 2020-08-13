using System;
using System.Collections.Generic;

namespace Lunch_Buddies
{
    class Restaurant
    {
        private List<string> RestaurantNames { get; set; } = new List<string>() { "McDonalds", "Taco Bell", "Dominoes", "Pizza Hut", "Burger King", "La Baguette" };
        public string Name { get; set; }

        public Restaurant()
        {
            var rnd = new Random();
            Name = RestaurantNames[rnd.Next(RestaurantNames.Count)];
        }
    }
}
