using System;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ContaCorrente pedro = new ContaCorrente();
            ContaCorrente lucas = new ContaCorrente();

            pedro.Depositar(1500);
            pedro.Transferir(lucas, 500);

            Console.WriteLine(pedro.saldo);
            Console.WriteLine(lucas.saldo);

            Console.ReadLine();
        }
    }
}
