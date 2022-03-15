using System;

namespace ByteBankHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Funcionario funcionario = new Funcionario("1234567890");
            //funcionario.Nome = "Roberta";
            //funcionario.Salario = 2000;

            //Console.WriteLine(funcionario.GetBonificacao());

            Diretor diretor = new Diretor("12345678901");
            diretor.Nome = "Pedro";
            diretor.Senha = "123";
            Console.WriteLine(diretor.Salario);

            
        }
    }
}
