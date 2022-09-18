using System;
namespace LiskovSubstitutionPrinciple.Solution
{
    public class Ceo : BaseEmployee, ICeo, IManager
    {
        public void FireSomeone(IEmployee employee)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName} has been just fired!");
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine($"CEO {FirstName} {LastName} is reviewing some stuff");
        }
    }
}

