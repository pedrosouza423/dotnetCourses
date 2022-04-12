using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; } 

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        } 

        public Conta(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Depositar(depositoInicial);
        }

        public void Sacar (double saldo)
        {
            double taxa = 5;
            if(saldo + taxa < Saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            Saldo -= saldo + taxa;
            Console.WriteLine("Saldo da conta atualizado:");
            Console.WriteLine($"Conta {Numero}, Titular {Titular}, Saldo");
        }

        public void Depositar(double saldo)
        {
            if (saldo <= 0)
            {
                Console.WriteLine("Não é permitido realizar deposito de valores negativos");
            }
            Console.WriteLine("Saldo da conta atualizado:");
            Console.WriteLine($"Conta {Numero}, Titular {Titular}, Saldo");
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular {Titular}, saldo: R${Saldo} ";
        }

    }
}
