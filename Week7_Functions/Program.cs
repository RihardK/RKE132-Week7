
Console.WriteLine("Are you coming or going? (coming/going)");
string userChoice = Console.ReadLine();

if (userChoice == "coming")
{
    PrintHello();
}
else 
{
    PrintGoodBye();
}


static void PrintHello()
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodBye()
{
    Console.WriteLine("The cold takes me...");
}