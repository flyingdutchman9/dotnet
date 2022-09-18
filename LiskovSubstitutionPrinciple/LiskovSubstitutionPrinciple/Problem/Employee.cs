namespace LiskovSubstitutionPrinciple.Problem
{
    public class Employee
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public decimal Salary { get; protected set; }
        public Employee Manager { get; private set; }

        public virtual void AssignManager(Employee manager)
        {
            Manager = manager;
        }

        public virtual void CalculatePerHourRate(decimal hourRate)
        {
            decimal baseAmount = 10M;

            Salary = baseAmount * hourRate * 8M;
        }
    }
}