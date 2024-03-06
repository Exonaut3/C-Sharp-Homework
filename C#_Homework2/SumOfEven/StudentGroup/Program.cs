string[] studentsG1 = { "Robert", "Shubnigurath", "Retardo", "Mandark", "Nostradamus" };
string[] studentsG2 = { "Ryan Gosling (me)", "Mar4e", "Murat", "Radica", "The water Dispenser" };

Console.WriteLine("Enter a group number (there are only 2 groups)");
bool validation = int.TryParse(Console.ReadLine(), out int number);
if (validation)
{
    if (number == 1)
    {
        for (int i = 0; i < studentsG1.Length; i++)
        {
            Console.WriteLine(studentsG1[i]);
        }
        Console.ReadLine();
    }
    else if (number == 2)
    {
        for (int i = 0; i < studentsG2.Length; i++)
        {
            Console.WriteLine(studentsG2[i]);
        }
        Console.ReadLine();

    }
    else Console.WriteLine("ERROR, Please insert a number that is either 1 or 2");
    Console.ReadLine();

}
else Console.WriteLine("ERROR, NAN");
Console.ReadLine();
