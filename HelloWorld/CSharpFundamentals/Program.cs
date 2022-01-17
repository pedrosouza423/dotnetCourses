using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pedro = new Person();
            pedro.FirstName = "Pedro";
            pedro.LastName = "Souza";
            pedro.Introduce();

            Calculator calculator = new Calculator();
            System.Console.WriteLine(calculator.Add(7, 9));
        }
    }
}
