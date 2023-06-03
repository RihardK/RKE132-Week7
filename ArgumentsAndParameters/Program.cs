
Console.WriteLine("Enter your word/phrase to be repeated:");
string userWord = Console.ReadLine();
PrintWords(userWord);

static void PrintWords(string anyString)
{
	anyString = anyString.ToUpper();
	for (int i = 0; i < 5; i++)
	{
		Console.WriteLine(anyString);
	}
}