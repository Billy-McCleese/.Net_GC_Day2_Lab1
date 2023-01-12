Console.Write("Please enter your name: ");
string name = Console.ReadLine();

if (string.IsNullOrEmpty(name) == true)
{
    Console.WriteLine("You did not enter a name!");
    return;
}

bool Close = false;
while (!Close)
{
    Console.Write("Hi " + name + " Please enter a positive number between 1-100: ");
    int number = int.Parse(Console.ReadLine());

    if (number <= 0)
    {
        Console.WriteLine(name + " Number must be Positive");
        return;
    }
    else if (number > 100)
    {
        Console.WriteLine(name + " Number must be between 1-100");
        return;
    }

    if ((number % 2 == 0) && (number >= 1 && number < 25))
    {
        Console.WriteLine(name + " , " + number + " is Even and Less than 25");
    }
    else if ((number % 2 == 0) && (number >= 26 && number < 61))
    {
        Console.WriteLine(name + " , " + number + " is even and between 26 and 60 inclusive");
    }
    else if (number % 2 != 0 && number < 60)
    {
        Console.WriteLine(name + " , " + number + " is odd and less than 60");
    }
    else if (number % 2 == 0 && number > 60)
    {
        Console.WriteLine(name + " , " + number + " is even and greater than 60");
    }
    else if (number % 2 != 0 && number > 60)
    {
        Console.WriteLine(name + " , " + number + " is odd and greater than 60");
    }
    Console.WriteLine(name + " ,would you like to go again?");
    string Continue = Console.ReadLine();
    if (Continue is "y") { Close = false; }
    else if (Continue is "Y") { Close = false; }
    else if (Continue is "Yes") { Close = false; }
    else if (Continue is "yes") { Close = false; }
    else { Close = true; Console.WriteLine("Goodbye " + name + "!"); }

}
