


// Kirjuta etteantud sõna suurte tahtedega 10 korda

Console.WriteLine("Enter a word");
string userInput = Console.ReadLine();

PrintAnyWord(userInput); //userInput on argument

static void PrintAnyWord(string anyString) //anystring on parameeter
{
    anyString = anyString.ToUpper();
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(anyString);
    }
}
