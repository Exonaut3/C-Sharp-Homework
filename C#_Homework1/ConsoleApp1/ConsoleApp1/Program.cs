
#region Task 1


Console.WriteLine("Enter the first number");
bool validation = int.TryParse(Console.ReadLine(), out int firstNumber);
if(validation)
{
    Console.WriteLine("Enter the second number");
    bool validation1 = int.TryParse(Console.ReadLine(), out int firstNumber1);
    if (validation1)
    {
        Console.WriteLine("What kind of operator would you like to use?");
        char operator1 = Console.ReadKey().KeyChar;
        Console.WriteLine(" ");
        if (((operator1 != '+') && (operator1 != '-') && (operator1 != '*') && (operator1 != '/')))
        {
            Console.WriteLine("ERROR, Unrecognized input value");
            Console.ReadLine();

        }
        else
        {
            if (operator1 == '-')
            {
                Console.WriteLine("The result is " + (firstNumber - firstNumber1));
                Console.ReadLine();

            }

            if (operator1 == '+')
            {
                Console.WriteLine("The result is " + (firstNumber + firstNumber1));
                Console.ReadLine();

            }

            if (operator1 == '*')
            {
                Console.WriteLine("The result is " + (firstNumber * firstNumber1));
                Console.ReadLine();

            }

            if (operator1 == '/')
            {
                Console.WriteLine("The result is " + (firstNumber / firstNumber1));
                Console.ReadLine();

            }
        }
    }
    else Console.WriteLine("ERROR, NaN");
    Console.ReadLine();

}
else Console.WriteLine("ERROR, NaN");
Console.ReadLine();






#endregion


