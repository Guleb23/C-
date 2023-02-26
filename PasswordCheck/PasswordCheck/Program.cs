
int passCount = 5;
string pass = "12345";
string userInput;
for (int i = 0; i < passCount; i++)
{
    Console.WriteLine("Enter password");
    userInput = Console.ReadLine();
    if (userInput == pass)
    {
        Console.WriteLine("You login");
        break;
    }
    else
    {
        Console.WriteLine("Please again. Count enries:" + ( passCount  - i - 1 ));
    }
}
