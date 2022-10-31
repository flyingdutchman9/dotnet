using SingletonTestThread.src;

StartAllTests();

void StartAllTests()
{
    Console.WriteLine("Switch to next method with enter");
    StartSimpleSafeTest();
    StartUnsafeTest();
}

void StartSimpleSafeTest()
{
    Console.WriteLine("------SIMPLE SAFE SINGLETON----");

    Thread first = new Thread(() => CreateSimpleSingletonInFirstThread("First thread"));
    Thread second = new Thread(() => CreateSimpleSingletonInSecondThread("Second thread"));

    first.Start();
    second.Start();

    Console.ReadLine();
}

static void CreateSimpleSingletonInFirstThread(string name)
{
    SingletonSimpleSafe singleton = SingletonSimpleSafe.Instance;
    singleton.WriteToConsole(name);
}

static void CreateSimpleSingletonInSecondThread(string name)
{
    SingletonSimpleSafe singleton = SingletonSimpleSafe.Instance;
    singleton.WriteToConsole(name);
}

static void StartUnsafeTest()
{
    Console.WriteLine("------UNSAFE SINGLETON----");
    Thread first = new Thread(() => CreateSingletonInFirstThread("First thread"));
    Thread second = new Thread(() => CreateSingletonInSecondThread("Second thread"));

    first.Start();
    second.Start();

    Console.ReadLine();
}

static void CreateSingletonInFirstThread(string name)
{
    SingletonUnsafe singleton = SingletonUnsafe.Instance;
    singleton.WriteToConsole(name);
}

static void CreateSingletonInSecondThread(string name)
{
    SingletonUnsafe singleton = SingletonUnsafe.Instance;
    singleton.WriteToConsole(name);
}