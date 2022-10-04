using System;
namespace CallChaining.LambdaWithEndMethod
{
    // Entry class has a static method with a Func with input and output types
    // Output type is the one that must be called at the end in order to finish execution
    public static class BeerAction
    {
        public static void DrinkABeer(Func<BeerOptions, BeerFinalOptions> beerOptions)
        {
            BeerFinalOptions beerFinalOptions = beerOptions(new BeerOptions());
        }
    }
}

