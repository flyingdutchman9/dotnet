using System;
namespace CallChaining.ChainingWithOrder.Interfaces
{
    // Just for easy overview, all interfaces placed into the same file
    public interface IAfterUnlockedCar : IEnterCar { }

    public interface IAfterEnteredCar : IPrepareForDrive { }

    public interface IAfterPrepareForDrive : IStartEngine { }

    public interface IAfterStartEngine : IDrive { }

    public interface IUnlockCar
    {
        IAfterUnlockedCar UnlockCar();
    }

    public interface IEnterCar
    {
        IAfterEnteredCar EnterCar();
    }

    public interface IPrepareForDrive
    {
        IPrepareForDrive FastenSeatbelt();
        IAfterPrepareForDrive InsertKey();
    }

    public interface IStartEngine
    {
        IAfterStartEngine StartEngine();
    }

    public interface IDrive
    {
        void Drive();
    }

    public interface IDriveToWork : IEnterCar
    {

    }
}

