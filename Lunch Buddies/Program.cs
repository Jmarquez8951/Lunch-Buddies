using System;
using System.Collections.Generic;

namespace Lunch_Buddies
{
    class Program
    {
        static void Main()
        {
            var john = new LunchBuddy("John","James");
            var l = new LunchBuddy("Lex","Luther");
            var m = new LunchBuddy("Max", "Lethal");
            var k = new LunchBuddy("Kathrine", "Kimberly");
            john.eat();
            john.eat("Tacos");
            var friends = new List<LunchBuddy>();
            friends.Add(l);
            friends.Add(m);
            friends.Add(k);

            john.eat(friends);

            john.eat("pizza", friends);
        }
    }
}
