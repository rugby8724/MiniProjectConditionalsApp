
Console.Write("What is your age? ");

string ageText = Console.ReadLine();

int.TryParse(ageText, out int age);

if (age >= 21)
{
    Console.WriteLine("Hello! What is your name? ");
    string name = Console.ReadLine();
    if (name.ToLower() == "bob" || name.ToLower() == "sue")
    {
        Console.WriteLine("Hello Professor");
    }
    else
    {
        Console.WriteLine($"Hello {name}, Welcome to the class");
    }
}
else
{
    Console.WriteLine($"Please wait {21-age}year(s) before coming to this class");
}
