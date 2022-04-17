using System;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escolha o numero de pessoas:");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];
            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }


            double average = sum / vect.Length;

            Console.WriteLine($"A media dos valores é {average}");

            //Conta conta;
            //Console.WriteLine("Digite o numero da conta: ");
            //int numero = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o nome do titular da conta: ");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Haverá um deposito inicial (s/n)?");
            //string depositoInicial = Console.ReadLine();

            //if(depositoInicial == "s")
            //{
            //    Console.WriteLine("Entre com o saldo inicial: ");
            //    double saldo = double.Parse(Console.ReadLine());
            //    conta = new Conta(numero, nome, saldo);
            //}
            //else
            //{
            //    conta = new Conta(numero, nome);

            //}

            //Console.WriteLine("Dados da conta:");
            //Console.WriteLine(conta);

            //Nullable
            //double? numero = 0;
            //Console.WriteLine(numero);




        }
    }
}
