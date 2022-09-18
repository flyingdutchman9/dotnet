using System;
namespace LiskovSubstitutionPrinciple.Solution
{
    public interface ICeo : IEmployee
    {
        void FireSomeone(IEmployee employee);
    }
}

