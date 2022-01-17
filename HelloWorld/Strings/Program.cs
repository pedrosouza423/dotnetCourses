using System;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new string[3] { "Pedro", "Luizinha", "Lucas" };

            var time = string.Join(",", names);
            Console.WriteLine(time);

            var firstName = "Pedro";
            var lastName = "Souza";

            var fullName = string.Join(' ', firstName, lastName);
            Console.WriteLine(fullName);

            var text = @"
Hey, my name is Pedro
I'm building this aplication
I'm having a lot of fun learning english and .NET
That's gonna be a great year
The most important thing, you're done
You're trying.
I'm pround of you :D

 _________________
|HAVE A GREAT 2022|
 -----------------";
            Console.WriteLine(text);

        }
    }
}
