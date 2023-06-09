var date = DateTime.UtcNow;
string name = GetName();

Menu(name);
string GetName()
{
    Console.WriteLine("Please type your name");

    var name = Console.ReadLine();
    return name;
}
void Menu(string name)
{
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. this is your math's game.\n");
    Console.WriteLine(@$"Choose a game for today!!!
A - Addition
S - Subtraction
M - Multiplication 
D - Division
Q - Quit the game");
    Console.WriteLine("-----------------------------------------");

    var gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition game selected");
            break;
        case "s":
            SubstractionGame("Substraction game selected");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected");
            break;
        case "d":
            DivisionGame("Division game selected");
            break;
        case "q":
            Console.WriteLine("Good bye!!!!!");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid input :v ");
            Environment.Exit(1);
            break;
    }
}
void AdditionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    int firstNumber = random.Next(1, 9);
    int secondNumber = random.Next(1, 9);

    Console.WriteLine($"{firstNumber} + {secondNumber}");
    var result = Console.ReadLine();

    if (int.Parse(result) == firstNumber + secondNumber)
    {
        Console.WriteLine("Your answer was correct!");
    }
    else
    {
        Console.WriteLine("Your answer was incorrect!");
    }

}
void SubstractionGame(string message)
{
    Console.WriteLine();
}
void MultiplicationGame(string message)
{
    Console.WriteLine(message);
}
void DivisionGame(string message)
{
    Console.WriteLine(message);
}

