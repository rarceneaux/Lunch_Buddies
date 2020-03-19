using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Resturant
    {
        List<string> Resturants { get; set; }

        public string Name { get; set; }

        public Resturant()
        {
            Resturants = new List<string> { "Logans", "Old Tymers", "Da Hood" };
            var randomPick  = new Random().Next(Resturants.Count);
            Name = Resturants[randomPick];
            Console.WriteLine($"The resturant is {Name}");
        }
    }
}
