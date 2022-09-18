using System;
namespace LiskovSubstitutionPrinciple.Solution
{
    public class SolutionMain
    {
        // Explanation of Solution architecture:
        // Every class inherits abstract BaseEmployee (directly or indirectly), but only BaseEmployee implements IEmployee
        // abstract class is used so no other class needs to implement IEmployee as it's all common.

        // All other specific classes (Ceo, Manager, ManagedEmployee) also implement their specific interface
        // Note that Manager inherits Employee so it can have it's own manager. Ceo can't, but can still manage and fire people

        // So...the application cannot be broken now in runtime
        // If we swap type, then we can get new functionality for it...ex. swap IManager to ICeo will give us FireSomeone()
        public SolutionMain()
        {
            WorkingExample1();
        }

        private static void WorkingExample1()
        {
            // Swapped instance from Manager to Ceo because they implement same Interface
            // Ceo can't be declared with IManaged, because it does not inherit...
            // ...but if it is inherited from something (like IManager), then it should work
            IManager manager = new Ceo();
            manager.FirstName = "George";
            manager.LastName = "Constantsky";
            manager.CalculatePerHourRate(HourRateType.RegularTime);
            
            // Regular IManaged instance
            IManaged employee = new Employee();
            employee.FirstName = "Jerry";
            employee.LastName = "Classovsky";
            employee.CalculatePerHourRate(HourRateType.Overtime);
            Console.WriteLine($"{employee.FirstName}'s salary is {employee.Salary} per day.");

            // Swapped instance from Employee to manager possible because Manager inherits Employee
            IManaged employee1 = new Manager();
            employee1.AssignManager(manager);
            employee1.FirstName = "Kramer";
            employee1.LastName = "Private";
            employee1.CalculatePerHourRate(HourRateType.Overtime);

            Console.WriteLine($"Newly assigned manager {employee1.FirstName}'s salary is {employee1.Salary} per day.");
        }
    }
}

