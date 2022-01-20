using System;

namespace ValueRefereceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(String.Format("a:{0} b:{1}", a,b));

            var array1 = new [] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;

            Console.WriteLine(array1[0]);


        }
    }
}
