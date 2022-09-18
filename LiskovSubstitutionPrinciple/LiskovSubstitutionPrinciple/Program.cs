// See https://aka.ms/new-console-template for more information
using LiskovSubstitutionPrinciple.Problem;
using LiskovSubstitutionPrinciple.Solution;


SelectionMenu();

void SelectionMenu()
{
    Console.WriteLine("Run problem or solution? Type a number");
    Console.WriteLine("1. Problem");
    Console.WriteLine("2. Solution");

    int selection = -1;
    int.TryParse(Console.ReadLine(), out selection);

    switch (selection)
    {
        case 1:
            new ProblemMain();
            break;
        case 2:
            new SolutionMain();
            break;
        default:
            Console.WriteLine("Selection must be number 1 or 2");
            Console.WriteLine();
            SelectionMenu();
            break;
    }

}




