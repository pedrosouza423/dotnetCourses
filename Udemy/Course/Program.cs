using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //double saldo = 5.9875;
            //string nome = "Pedro";
            //Console.WriteLine($"{nome} tem o saldo de {saldo:F2}");
            //Console.WriteLine(saldo.ToString("F2"));

            //double a = 2, b = 3, c = 2;
            //double delta = Math.Pow(b, 2) - 4.0 * a * c ;
            //double x1 = (-b + Math.Sqrt(delta)) / (2*a);
            //double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            //Questão 1
            //int a, b, soma;
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());

            //soma = a + b;
            //Console.WriteLine(soma);

            //Questão 2
            //double raio, area;
            //raio = double.Parse(Console.ReadLine());
            //area = Math.Pow(raio,2) * 3.14159;
            //Console.WriteLine(area);

            //Questão 3
            //int a, b, c, d;
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //c = int.Parse(Console.ReadLine());
            //d = int.Parse(Console.ReadLine());

            //int diferenca = ((a * b) - (c * d));

            //Console.WriteLine(diferenca);

            //Parte 2

            //Console.WriteLine("Digite um numero");
            //double num = double.Parse(Console.ReadLine());

            //if (num > 0)
            //{
            //    Console.WriteLine("O numero é positivo");
            //}else if(num == 0)
            //{
            //    Console.WriteLine("O numero é nulo");
            //}
            //else
            //{
            //    Console.WriteLine("O numero é negativo");
            //}

            //string[] valores = Console.ReadLine().Split(' ');
            //int horaInicial = int.Parse(valores[0]);
            //int horaFinal = int.Parse(valores[1]);

            //int duracao;
            //if(horaInicial < horaFinal)
            //{
            //    duracao = horaFinal - horaInicial;
            //}
            //else
            //{
            //    duracao = 24 - horaInicial + horaFinal ;
            //}

            //Console.WriteLine(duracao);

            Produto produto = new Produto();
            produto.Nome = "Tv";
            produto.Preco = 900;
            produto.Quantidade = 10;



        }
    }
}
