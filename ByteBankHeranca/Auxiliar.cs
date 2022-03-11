using System;

namespace ByteBankHeranca
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {

        }

        public override double GetBonificacao()
        {
            return Salario *= 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

    }
}
