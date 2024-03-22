using EnumNewName.Classes;
#region Methods

static void IsWeekend(Days day)
{
    if(day == Days.Saturday || day == Days.Sunday)
    {
        Console.WriteLine($"Yay finally AAAAAAAAAAAAAAAAAAA ITS {day}");
    }
    else
    {
        Console.WriteLine($"I'm going to end myself. It's fucking {day}");
    }
}
#endregion


#region Using Enums
Days monday = Days.Monday;
Days Sunday = Days.Sunday;

IsWeekend(monday);
IsWeekend(Sunday);
#endregion

#region Converting Enum
int num = 2;
Days dayTwo = (Days)num;
Console.WriteLine(dayTwo);

Days dayThree = Days.Wednesday;
int numThree = (int)dayThree;
Console.WriteLine(numThree);

Days numFour = Days.Thursday;
string stringDay = numFour.ToString(); //vraka Thursday 
Console.WriteLine(stringDay);

Console.WriteLine("Enter enum");
string input = Console.ReadLine();

if(Enum.TryParse(input, out Days inputDay))
{
    Console.WriteLine($"You enter enum: {inputDay}");
}
else
{
    Console.WriteLine("Error");
}


#endregion