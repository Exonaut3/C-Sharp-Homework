Console.WriteLine("Insert the FIRST number");
bool validation = int.TryParse(Console.ReadLine(), out int firstNumber);
if (validation)
{
    Console.WriteLine("Insert the SECOND number");
    validation = int.TryParse(Console.ReadLine(), out int secondNumber);
    if (validation)
    {
        Console.WriteLine("Insert the THIRD number");
        validation = int.TryParse(Console.ReadLine(), out int thirdNumber);
        if (validation)
        {
            Console.WriteLine("Insert the FOURTH number");
            validation = int.TryParse(Console.ReadLine(), out int fourthNumber);
            if (validation)
            {
                float average = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
                Console.WriteLine("The average of " + firstNumber + " " + secondNumber + " " + thirdNumber + " " + fourthNumber + " " + "is " + average);
                Console.ReadLine();
            }
            else Console.WriteLine("ERROR, NAN");
            Console.ReadLine();
        }
        else Console.WriteLine("ERROR, NAN");
        Console.ReadLine();
    }
    else Console.WriteLine("ERROR, NAN");
    Console.ReadLine();
}
else Console.WriteLine("ERROR, NAN");
Console.ReadLine();
