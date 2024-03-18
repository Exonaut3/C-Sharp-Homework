int[] array = new int[5];
bool validation;
int result = 0 ;
while (true)
{
    Console.WriteLine("Insert the value of the first number in the array ");
    validation = int.TryParse(Console.ReadLine(), out array[0]);
    if (!validation)
    {
        Console.WriteLine("ERROR, Please insert a number \n");
        continue;
    }
    Console.WriteLine("Insert the value of the second number in the array ");
    validation = int.TryParse(Console.ReadLine(), out array[1]);
    if (!validation)
    {
        Console.WriteLine("ERROR, Please insert a number \n");
        continue;
    }
    Console.WriteLine("Insert the value of the third number in the array ");
    validation = int.TryParse(Console.ReadLine(), out array[2]);
    if (!validation)
    {
        Console.WriteLine("ERROR, Please insert a number \n");
        continue;
    }
    Console.WriteLine("Insert the value of the fourth number in the array ");
    validation = int.TryParse(Console.ReadLine(), out array[3]);
    if (!validation)
    {
        Console.WriteLine("ERROR, Please insert a number \n");
        continue;
    }
    Console.WriteLine("Insert the value of the fifth number in the array ");
    validation = int.TryParse(Console.ReadLine(), out array[4]);
    if (!validation)
    {
        Console.WriteLine("ERROR, Please insert a number \n");
        continue;
    }

    for (int i = 0; i < array.Length; i++)
    {
         result += array[i];
    }
    Console.WriteLine( $"The sum of the numbers you inputed is {result}");
    break;
}

// Pretpostavuvam ova deka se bara


int result2 = 0;
int[] array2 = { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) };

for (int i = 0; i<array2.Length; i++)
{
    result2 += array2[i];
}
Console.WriteLine(result2);

//Ili ova