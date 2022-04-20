using System;

namespace MatrizExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many orders are in matriz? ");
            int order = int.Parse(Console.ReadLine());
            int[,] mat = new int[order, order];

            for (int i = 0; i < order; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < order; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < order; i++)
            {
                Console.Write(mat[i,i]+ " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < order; i++)
            {
                for (int j = 0; j < order; j++)
                {
                   if(mat[i,j] < 0)
                    {
                        count++;
                    } 
                }
            }

            Console.WriteLine($"Negative numbers: {count}");
        }
    }
}
