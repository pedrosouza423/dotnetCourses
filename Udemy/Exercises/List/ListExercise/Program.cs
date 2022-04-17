using System;
using System.Collections.Generic;

namespace ListExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered?");
            int numberEmplyees = int.Parse(Console.ReadLine());

            Employee employee = new Employee();
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < numberEmplyees; i++)
            {
                Console.WriteLine($"Employee #{i + 1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                employee.Id = id;
                employee.Name = name;
                employee.Salary = salary;

            }

            //Console.WriteLine("Enter the employee id that will have salary increase: ");
            //int increaseSalartId = int.Parse(Console.ReadLine());

            //if (increaseSalartId == )

            //foreach (Employee employee in employees)
            //{
            //    if(employee.Id != increaseSalartId)
            //    {
                    
            //    }
            //}

            //Console.WriteLine("Enter the percentage: ");
            //int increasePercentage = int.Parse(Console.ReadLine());




        }
    }
}
