using System;

namespace ByteBankHeranca
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000)
        {

        }

        public override double GetBonificacao()
        {
            return Salario *= 0.11;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

    }
}
