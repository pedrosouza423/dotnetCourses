using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    internal class ContaCorrente
    {
        public string titular;
        private double saldo;
        public string agencia;
        public string numero;

        public ContaCorrente()
        {
               
        }

        public void Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
            this.saldo -= valor;
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
            this.saldo += valor;
        }

        public void Transferir(ContaCorrente conta,double valor)
        {
            if (this.saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
            this.Sacar(valor);
            conta.Depositar(valor);
        }

    }
}
