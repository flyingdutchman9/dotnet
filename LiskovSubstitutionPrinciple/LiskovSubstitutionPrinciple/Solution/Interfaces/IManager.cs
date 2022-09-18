using System;
namespace LiskovSubstitutionPrinciple.Solution
{
    public interface IManager : IEmployee
    {
        void GeneratePerformanceReview();
    }
}

