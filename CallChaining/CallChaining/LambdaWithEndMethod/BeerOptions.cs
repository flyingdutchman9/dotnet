namespace CallChaining.LambdaWithEndMethod
{
    public class BeerOptions
    {
        private string? _message;
        private bool isDrinkingFromTheBottle = true;

        public BeerOptions PourIntoGlass(BeerType beerType)
        {
            $"You are pouring a {beerType.ToString()} beer into the glass".Output();
            isDrinkingFromTheBottle = false;
            return this;
        }

        public BeerOptions SetCheersMessage(string message)
        {
            _message = message;
            return this;
        }

        public BeerOptions Cheers()
        {
            if (string.IsNullOrWhiteSpace(_message))
            {
                $"You have raised a toast without a speech".Output();
            }
            else
            {
                $"You have raised a toast with the message: {_message}".Output();
            }

            return this;
        }

        public BeerFinalOptions StartDrinking()
        {
            string drinkFrom = isDrinkingFromTheBottle ? "bottle" : "glass";
            $"You are drinking a beer from a {drinkFrom} with your friends".Output();

            return new BeerFinalOptions(this);
        }
    }
}