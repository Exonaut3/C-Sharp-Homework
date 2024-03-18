string[] arrayOfNames = new string[1];
int sizeCounter = 1;
int indexCoutner = 0;


while (true)
{
    Console.WriteLine("Would you like to insert a name into the array? (Y/N)");
    string response = Console.ReadLine();
    if (response.ToLower() == "y")
    {
        Array.Resize(ref arrayOfNames, sizeCounter);
        Console.WriteLine("Enter a name you would like to add");
        arrayOfNames[indexCoutner] = Console.ReadLine();
        sizeCounter++;
        indexCoutner++;
    }
    else if (response.ToLower() == "n")
    {
        if (arrayOfNames[0] == null)
        {
            Console.WriteLine("You didn't insert any names so there's nothing to write down. Why make me go through all this code if you won't insert a name???? hmmm!?!?!? At least put 1 in. Try again");
        }
        else
        {
            Console.WriteLine("Here are the names you wrote down:");
            for (int i = 0; i < arrayOfNames.Length; i++)
            {
                Console.WriteLine(arrayOfNames[i]);
            }
            break;
        }
        
    }
    else
    {
        Console.WriteLine("Please insert a valid response");
    }
}




