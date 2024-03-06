int container = 0;

Console.WriteLine("Insert the FIRST NUMBER");
bool validation = int.TryParse(Console.ReadLine(), out int firstInt);
if (validation)
{
    Console.WriteLine("Insert the SECOND NUMBER");
    validation = int.TryParse(Console.ReadLine(), out int secondInt);
    if (validation)
    {
        Console.WriteLine("Insert the THIRD NUMBER");
        validation = int.TryParse(Console.ReadLine(), out int thirtdInt);
        if (validation)
        {
            Console.WriteLine("Insert the FOURTH NUMBER");
            validation = int.TryParse(Console.ReadLine(), out int fourthInt);
            if (validation)
            {
                Console.WriteLine("Insert the FIFTH NUMBER");
                validation = int.TryParse(Console.ReadLine(), out int fifthInt);
                if (validation)
                {
                    Console.WriteLine("Insert the SIXTH NUMBER");
                    validation = int.TryParse(Console.ReadLine(), out int sixthInt);
                    if (validation)
                    {
                        int[] array = new int[6];
                        array[0] = firstInt;
                        array[1] = secondInt;
                        array[2] = thirtdInt;
                        array[3] = fourthInt;
                        array[4] = fifthInt;
                        array[5] = sixthInt;

                        for(int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 == 0)
                            {
                                container += array[i];
                            }
                        }
                        Console.WriteLine("The sum of all the even numbers is: " + container);
                        Console.ReadLine();
                    }
                    else Console.WriteLine("ERROR NAN");
                    Console.ReadLine();
                }
                else Console.WriteLine("ERROR NAN");
                Console.ReadLine();
            }
            else Console.WriteLine("ERROR NAN");
            Console.ReadLine();
        }
        else Console.WriteLine("ERROR NAN");
        Console.ReadLine();
    }
    else Console.WriteLine("ERROR NAN");
    Console.ReadLine();
}
else Console.WriteLine("ERROR NAN");
Console.ReadLine();
//I love nesting man :DDDDDDDDDDDDDDD