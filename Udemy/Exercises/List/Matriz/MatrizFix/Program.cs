using System;

namespace MatrizFix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value M");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value N");
            int n = int.Parse(Console.ReadLine());

            double[,] mat = new double[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]); 
                }
            }

            Console.WriteLine("Enter a value:");
            int value = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(mat[i, j] == value)
                    {
                        Console.WriteLine($"Position : {i} {j}");

                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }

        }
    }
}
