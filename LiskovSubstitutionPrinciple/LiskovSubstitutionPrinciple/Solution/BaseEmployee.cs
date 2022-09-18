using System;
namespace LiskovSubstitutionPrinciple.Solution
{
    public abstract class BaseEmployee : IEmployee
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal Salary { get; set; }

        public virtual void CalculatePerHourRate(decimal hourRate)
        {
            decimal baseAmount = 30M;

            Salary = baseAmount * hourRate;
        }
    }
}

