using System;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Winter;

            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("The flowers are growing up");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's the perfect time to go to the beach");
                    break;
                case Season.Winter:
                    Console.WriteLine("It's the perfect time to practice snowboard");
                    break;
                case Season.Fall:
                    Console.WriteLine("Fall it's so beautiful");
                    break;
                default:
                    Console.WriteLine("I don't understand this season");
                    break;
            }

            //var hour = 18;

            //if (hour > 0 && hour < 12)
            //{
            //    Console.WriteLine("It's morning");
            //}else if (hour >=12 && hour < 18)
            //{
            //    Console.WriteLine("It's afternoon");
            //}
            //else
            //{
            //    Console.WriteLine("It's night");
            //}
        }
    }
}
