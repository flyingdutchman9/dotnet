using System;
namespace LiskovSubstitutionPrinciple.Problem
{
    public class ProblemMain
    {
        // First problem by LSP here is, if Employee is expected to work in one way, and
        // Ceo is expected to work in another way, that's a problem (see comment in the second method)

        // Second problem, if we create another class, ex. Janitor, maybe we must be able to
        // change Calculate method. Issue here is that when creating Employee class, we have to think
        // through which methods must be virtual...otherwise we won't be able to change behaviour.

        // We could change Calculate method in base class, but then we break OCP principle
        public ProblemMain()
        {
            WorkingExample();
            CeoBreakTheAppExample();
            Console.ReadLine();
        }

        // Working example here is just to distinguish difference between "bad idea" that works and the problem we can run into
        private static void WorkingExample()
        {
            Manager financeManager = new Manager();
            financeManager.FirstName = "George";
            financeManager.LastName = "Constantsky";

            financeManager.CalculatePerHourRate(HourRateType.RegularTime);

            Employee employee = new Employee();
            employee.FirstName = "Jerry";
            employee.LastName = "Classovsky";


            employee.AssignManager(financeManager);
            employee.CalculatePerHourRate(HourRateType.Overtime);

            Console.WriteLine($"{employee.FirstName}'s salary is {employee.Salary} per day.");
        }

        // We cannot assign a manager to Ceo, but the code allows us that.
        // LSP says that if you have a child of an object, Ceo inherits Employee in our case,
        // Ceo should be able to be placed anywhere we see Employee, and NOT break the application
        private static void CeoBreakTheAppExample()
        {
            Manager financeManager = new Manager();
            financeManager.FirstName = "George";
            financeManager.LastName = "Constantsky";

            financeManager.CalculatePerHourRate(HourRateType.RegularTime);

            Employee employee = new Ceo();
            employee.FirstName = "Jerry";
            employee.LastName = "Classovsky";


            employee.AssignManager(financeManager);
            employee.CalculatePerHourRate(HourRateType.Overtime);

            Console.WriteLine($"{employee.FirstName}'s salary is {employee.Salary} per day.");
        }
    }
}

