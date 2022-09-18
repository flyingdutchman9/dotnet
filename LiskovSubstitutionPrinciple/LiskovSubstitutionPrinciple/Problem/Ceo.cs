namespace LiskovSubstitutionPrinciple.Problem
{
    public class Ceo : Employee
    {
        public override void CalculatePerHourRate(decimal hourRate)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount * hourRate;
        }

        public override void AssignManager(Employee manager)
        {
            throw new InvalidOperationException("The CEO has no manager");
        }
    

        public void FireSomeone(Employee employee)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName} has been just fired!");
        }
    }
}