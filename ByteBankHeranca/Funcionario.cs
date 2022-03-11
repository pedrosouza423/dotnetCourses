using System;

namespace ByteBankHeranca
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            Console.WriteLine("Funcionario");
            CPF = cpf;
            Salario = salario;
        }

        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
    }
}
