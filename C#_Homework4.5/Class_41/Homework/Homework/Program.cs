


while (true)
{
    Console.WriteLine("Enter your email retard");
    string email = Console.ReadLine();

    bool atCheck = email.Contains("@");
    bool dotCheck = email.Contains(".");
    if (!atCheck || !dotCheck)
    {
        Console.WriteLine("Try again retard");
        continue;
    }
    

}
