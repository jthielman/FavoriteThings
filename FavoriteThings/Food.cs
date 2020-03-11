using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Food
    {
        public string Name { get; set; }
        public string Origin { get; set; }
        public int TimesEaten { get; set; }

        public void Eat()
        {
            TimesEaten += 1;
            Console.WriteLine($"{Name} has been eaten {TimesEaten} times.");
        }

        public void Cook()
        {
            Console.WriteLine($"You cook {Name}");
        }
    }
}
