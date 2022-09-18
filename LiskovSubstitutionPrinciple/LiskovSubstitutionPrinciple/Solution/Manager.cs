namespace LiskovSubstitutionPrinciple.Solution
{
    public class Manager : Employee, IManager
    {
        public override void CalculatePerHourRate(decimal hourRate)
        {
            decimal baseAmount = 80M;

            Salary = baseAmount * hourRate;
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine($"Manager {FirstName} {LastName} is reviewing some performance");
        }
    }
}