using System;

namespace ByteBankHeranca
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
            Console.WriteLine("Diretor");
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

    }
}
