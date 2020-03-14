using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var burger = new Food
            {
                Name = "hamburger",
                Origin = "America",
                TimesEaten = 2
            };
            var apfelkuchen = new Food
            {
                Name = "Apfelkuchen",
                Origin = "Germany",
                TimesEaten = 1
            };

            var berlin = new City
            {
                Name = "Berlin",
                Location = "Germany",
                TimesVisited = 10
            };

            var louisville = new City
            {
                Name = "Louisville",
                Location = "Kentucky",
                TimesVisited = 1
            };

            var lotr = new Book
            {
                Name = "The Lord of the Rings",
                Author = "J.R.R. Tolkien",
                TimesRead = 5
            };

            var grimm = new Book
            {
                Name = "Sämtliche Kinder- und Hausmärchen",
                Author = "Gebrüder Grimm",
                TimesRead = 0
            };

            var hood = new Garment
            {
                Name = "medieval hood",
                Type = "headwear",
                TimesWorn = 8
            };

            var tunic = new Garment
            {
                Name = "tunic",
                Type = "torso covering",
                TimesWorn = 10
            };

            burger.Cook();
            burger.Eat();
            apfelkuchen.Cook();
            apfelkuchen.Eat();
            berlin.Visit();
            berlin.Leave();
            louisville.Visit();
            louisville.Leave();
            lotr.Read();
            lotr.Recommend();
            grimm.Read();
            grimm.Recommend();
            hood.Sew();
            hood.Wear();
            tunic.Sew();
            tunic.Wear();
            Console.ReadLine();
        }
    }
}
