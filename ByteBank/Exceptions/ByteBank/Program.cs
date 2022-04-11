using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            try
            {
            ;//myClass.Metodo();
                ContaCorrente contaCorrente = new ContaCorrente(23,123);
                ContaCorrente contaCorrente2 = new ContaCorrente(24, 125);


                contaCorrente.Depositar(1000);
                contaCorrente.Transferir(300, contaCorrente2);

                Console.WriteLine(contaCorrente.Saldo);

                //Console.WriteLine("Well done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }


            Console.ReadLine();
        }

        public class MyClass
        {

            public void Dividir(int numero, int divisor)
            {
                    Console.WriteLine(numero / divisor);

            }

            public void Metodo()
            {
                testaDivisao(0);

            }

            public void testaDivisao(int divisor)
            {
                Dividir(10, divisor);
            }
        }


    }
        
}
