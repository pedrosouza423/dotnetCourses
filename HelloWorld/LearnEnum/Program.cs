using System;

namespace LearnEnum
{
    //This constant are related
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var test = ShippingMethod.Express;
            Console.WriteLine((int)test);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
            */

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine((int)shippingMethod);
        }
    }
}
