Console.WriteLine("Insert the FIRST number");
bool validation = int.TryParse(Console.ReadLine(), out int firstNumber);
if (validation)
{
    Console.WriteLine("Insert the SECOND number");
    validation = int.TryParse(Console.ReadLine(), out int secondNumber);
    if (validation)
    {

        int container = firstNumber;
        firstNumber = secondNumber;
        secondNumber = container;

        Console.WriteLine("The Value of the first number is now " + firstNumber);
        Console.WriteLine("The Value of the second number is now " + secondNumber);
        Console.WriteLine("Get bamboozled lmao");
        Console.WriteLine("Flipped even");
        Console.WriteLine("Here's a random Console.Readline() so you can take all of this in");
        Console.ReadLine();

    }
    else Console.WriteLine("ERROR, NAN");
    Console.ReadLine();

}
else Console.WriteLine("ERROR, NAN");
Console.ReadLine();
