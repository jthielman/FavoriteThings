using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int TimesRead { get; set; }

        public void Read()
        {
            TimesRead += 1;
            Console.WriteLine($"{Name} has been read {TimesRead} times.");
        }

        public void Recommend()
        {
            Console.WriteLine($"You recommend {Name}");
        }
    }
}
