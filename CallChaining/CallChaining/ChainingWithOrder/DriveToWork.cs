using CallChaining.ChainingWithOrder.Interfaces;

namespace CallChaining.ChainingWithOrder
{
    public class DriveToWork : IDriveToWork, IAfterUnlockedCar, IAfterEnteredCar, IAfterPrepareForDrive, IAfterStartEngine, IDrive
    {
        private bool isSeatBeltFastened;

        public IAfterEnteredCar EnterCar()
        {
            $"You have entered your car".Output();

            return this;
        }

        public IPrepareForDrive FastenSeatbelt()
        {
            $"You have fastened a seat belt".Output();
            isSeatBeltFastened = true;

            return this;
        }

        public IAfterPrepareForDrive InsertKey()
        {
            "Your car doesn't use key".Output();

            return this;
        }

        public IAfterStartEngine StartEngine()
        {
            $"Engine is running...".Output();

            return this;
        }

        public void Drive()
        {
            string drivingSafelyText = isSeatBeltFastened ?
                "but it could be dangerous without seat belt." :
                "safely";

            $"You are driving to work, {drivingSafelyText}".Output();
        }

    }
}

