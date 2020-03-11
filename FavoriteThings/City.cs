using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class City
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int TimesVisited { get; set; }

        public void Visit()
        {
            TimesVisited += 1;
            Console.WriteLine($"{Name} has been visited {TimesVisited} times.");
        }

        public void Leave()
        {
            Console.WriteLine($"You leave {Name}");
        }
    }
}
