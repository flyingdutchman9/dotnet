using System;
namespace LiskovSubstitutionPrinciple.Solution
{
    public interface IManaged : IEmployee
    {
        public IEmployee Manager { get; set; }

        void AssignManager(IEmployee manager);
    }
}

