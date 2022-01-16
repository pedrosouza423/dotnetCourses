using System;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                var idade = "121233";
                byte a = Convert.ToByte(idade);
                Console.WriteLine(a);
            }
            catch (Exception)
            {

                Console.WriteLine("The number could not be converted to a byte");
            }

            
        }
    }
}
