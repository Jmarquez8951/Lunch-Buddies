using System;
using System.Collections.Generic;
using System.Text;

namespace Lunch_Buddies
{
    class LunchBuddy
    {
        public string First { get; set; }
        public string Last { get; set; }
        public LunchBuddy(string first, string last)
        {
            First = first;
            Last = last;
        }

        public void eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{First} {Last} ate at {restaurant.Name}.");
        }

        public void eat(string food)
        {
            Console.WriteLine($"{First} {Last} ate {food} at the office.");
        }

        public void eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            string people = "";
            for (int i = 0; i < companions.ToArray().Length; i++)
            {
                if (i == companions.ToArray().Length - 1)
                {
                    people += "and " + companions[i].First;
                }
                else
                {
                    people += companions[i].First + ", ";
                }
            }
            Console.WriteLine($"{First} {Last} is eating at {restaurant.Name} with {people}.");
        }

        public void eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            string people = "";
            for (int i = 0; i < companions.ToArray().Length; i++)
            {
                if (i == companions.ToArray().Length - 1)
                {
                    people += "and " + companions[i].First;
                }
                else
                {
                    people += companions[i].First + ", ";
                }
            }
            Console.WriteLine($"{First} {Last} is eating {food} at {restaurant.Name} with {people}.");

        }
    }
}
