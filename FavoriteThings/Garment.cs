using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Garment
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int TimesWorn { get; set; }

        public void Wear()
        {
            TimesWorn += 1;
            Console.WriteLine($"{Name} has been worn {TimesWorn} times.");
        }

        public void Sew()
        {
            Console.WriteLine($"You sew a new {Name}");
        }
    }
}
