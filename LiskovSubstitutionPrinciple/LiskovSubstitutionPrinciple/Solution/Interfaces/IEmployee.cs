namespace LiskovSubstitutionPrinciple.Solution
{
    public interface IEmployee
    {
        string? FirstName { get; set; }
        string? LastName { get; set; }
        decimal Salary { get; }

        void CalculatePerHourRate(decimal hourRate);
    }
}