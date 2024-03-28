int yesNoCounter = 0;
Queue<int> numbersQueue = new Queue<int>();
bool validation;

while (true)
{
    Console.WriteLine("Enter a number you would like to add to the queue");
    string numberInput = Console.ReadLine();
    validation = int.TryParse(numberInput, out int number);
    if (!validation)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid input, try again.");
        Console.ResetColor();
        continue;
    }
    numbersQueue.Enqueue(number);
    while (true)
    {
        Console.WriteLine("Would you like to enter another number? (Y/N)");
        string answer = Console.ReadLine();
        if(answer.ToLower() == "y")
        {
            yesNoCounter = 1;
            break;
        }
        else if (answer.ToLower() == "n")
        {
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input try again sweetie :))))");
            Console.WriteLine("It's because of people like you that I have to use counters to make sure everything works nicely :))))");
            Console.ResetColor();
            continue;
        }
    }
    if(yesNoCounter == 1)
    {
        yesNoCounter = 0;
        continue;
    }
    else
    {
        foreach (int numberAdded in numbersQueue)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(numberAdded);
            Console.ResetColor();
        }
        // ima mislam i drug interesen nachin da se napravi ovoj del ali odluchiv vaka da go napravam
        // vo sluchaj da beshe stack ke go napravev so for loop kade sto ke gi indeksira vnesenite vrednosti od krajot kon pochetokot
        break;
    }
}