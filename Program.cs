using System.Runtime.CompilerServices;

Console.WriteLine("Welcome to the Number Analyzer, what is your name?");
string name = Console.ReadLine();

while (true)
{
    Console.WriteLine($"{name}, please enter a number 1 to 100.");
    int usernum = int.Parse(Console.ReadLine());
    if (usernum <= 100 && usernum >= 1) {

        if (usernum % 2 == 1 && usernum < 60)
        {
            Console.WriteLine($"you entered {usernum}, this is an odd number and less than 60");
        }
        else if (usernum % 2 == 0 && usernum >= 2 && usernum <= 24)
        {
            Console.WriteLine($"{name}, your number was {usernum}, this is even and less then 25.");
        }
        else if (usernum % 2 == 0 && usernum >= 26 && usernum <= 60)
        {
            Console.WriteLine($"{name}, your number was {usernum}, this is even and between 26 - 60 inclusive.");
        }
        else if (usernum % 2 == 0 && usernum > 60)
        {
            Console.WriteLine($" {name}, your number was {usernum}, this is even and greater than 60.");
        }
        else
        {
            Console.WriteLine($" {name}, your number was {usernum}, this an odd number and greater than 60.");
        }
        Console.WriteLine("Want to leave? y/n");
        string choice = Console.ReadLine();
        if (choice == "y")
        {
            break;
        }
    }
}







