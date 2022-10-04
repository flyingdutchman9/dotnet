// See https://aka.ms/new-console-template for more information
using CallChaining.ChainingWithOrder;
using CallChaining.ChainingWithOrder.Interfaces;
using CallChaining.LambdaWithEndMethod;

// Won't work!!! Must have an end method ..StartDrinking in our case
// BeerAction.DrinkABeer(b => b.PourIntoGlass(BeerType.Lager).Cheers());

BeerAction.DrinkABeer(b => b.PourIntoGlass(BeerType.Lager).Cheers().StartDrinking());

"".Output();

BeerAction.DrinkABeer(b =>b
                        .SetCheersMessage("We are drinking for todays good job")
                        .Cheers()
                        .StartDrinking());

"".Output();
"----------------G O I N G   T O   W O R K-----------------------".Output();
new DriveToWork()
    .EnterCar()
    .FastenSeatbelt()
    .InsertKey()
    .StartEngine();


"----------------G O I N G   T O   W O R K  L I M I T E D-----------------------".Output();

// using interface, we are forced to use the first method.
IDriveToWork driveToWork = new DriveToWork();

driveToWork
    .EnterCar()
    .InsertKey()
    .StartEngine()
    .Drive();