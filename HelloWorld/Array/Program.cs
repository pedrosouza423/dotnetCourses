using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 25;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var names = new string[3] {"Pedro","Lucas","Luizinha"};
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);

        }
    }
}
