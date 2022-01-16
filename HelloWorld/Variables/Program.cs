using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte number = 255;
            int exemplo = number;
            Console.WriteLine(exemplo);

            string nome = "Pedro";
            double salary = 10500.5;

            Console.WriteLine(number);
            Console.WriteLine(salary);
            Console.WriteLine(nome);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            

        }
    }
}
