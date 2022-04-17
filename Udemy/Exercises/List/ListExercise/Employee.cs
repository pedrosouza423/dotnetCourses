using System;
using System.Collections.Generic;
using System.Text;

namespace ListExercise
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void increaseSalary(double percentage)
        {
            Salary += percentage;
        }

        public void validationId(int id)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Updated list of employees: " +
                $"{Name}";
        }


    }
}
