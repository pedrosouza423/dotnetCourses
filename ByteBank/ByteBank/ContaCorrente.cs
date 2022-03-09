using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    internal class ContaCorrente
    {
        public Titular Titular { get; set; }
        public double Saldo { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
       
    
        public ContaCorrente (int agencia, int numero)
	    {

	    }
        

        public void Sacar(double valor)
        {
            if (Saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
            Saldo -= valor;
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
            Saldo += valor;
        }

        public void Transferir(ContaCorrente conta,double valor)
        {
            if (Saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
            this.Sacar(valor);
            conta.Depositar(valor);
        }

    }
}
