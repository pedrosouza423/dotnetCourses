using System;

namespace ByteBankHeranca
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        public FuncionarioAutenticavel(string cpf, double salario) : base(cpf, 5000)
        {
        }

        public bool Autenticar(string senha)
        { 
            return Senha == senha;
        }


    }
}
