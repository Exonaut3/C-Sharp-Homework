
using Microsoft.VisualBasic;

static void AgeCalculator(string input)
{
    string now = DateTime.Now.ToString("d");
    string[] split = now.Split('.');
    int nowDay = int.Parse(split[0]);
    int nowMonth = int.Parse(split[1]);
    int nowYear = int.Parse(split[2]);

    string[] bdaySplit = input.Split(".");
    int bdayDay = int.Parse(bdaySplit[0]);
    int bdayMonth = int.Parse(bdaySplit[1]);
    int bdayYear = int.Parse(bdaySplit[2]);

    if(input == now)
    {
        Console.WriteLine("YOU ARE LITERALLY BORN TODAY. CONGRATULATIONS!!!");
    }
    else if (bdayYear > nowYear)
    {
        Console.WriteLine("You haven't been born yet, please wait until your birth year to test this code thank you <3");
    }
    else
    {
        //int daysOld = bdayDay - nowDay;
        //if(daysOld < 0)
        //{

        //}

        int yearsOld = nowYear - bdayYear;
        int monthsOld = nowMonth - bdayMonth;
        int daysOld = nowDay - bdayDay;
        

        if(monthsOld < 0)
        {
            monthsOld = 12 + monthsOld;
            yearsOld = yearsOld - 1 ;
        }
        if (daysOld < 0)
        {
            if (monthsOld == 2 && bdayYear % 4 == 0)
            {
                daysOld = 29 + daysOld;
            }
            else if (monthsOld == 2)
            {
                daysOld = 28 + daysOld;
            }
            else if(monthsOld % 2 == 0)
            {
                daysOld = 30 + daysOld;
            }
            else
            {
                daysOld = 31 + daysOld;
            }
            monthsOld = monthsOld - 1 ;
        }

        Console.WriteLine($"You are {yearsOld} years, {monthsOld} months and around {daysOld} days old");

    }



    foreach (string day in split)
    {
        Console.WriteLine(day);

    }


}




while (true)
{
    Console.WriteLine("Enter the day of the month you were born in");
    string day = Console.ReadLine();

    Console.WriteLine("Enter the month you were born in");
    string month = Console.ReadLine();

    Console.WriteLine("Enter the year you were born");
    string year = Console.ReadLine();

    bool dayValidation = int.TryParse(day, out int dayParsed);
    bool monthValidation = int.TryParse(month, out int monthParsed);
    bool yearValidation = int.TryParse(year, out int yearParsed);

   



    if (!dayValidation || !monthValidation || !yearValidation)
    {
        Console.WriteLine("Invalid input try again \n");
        continue;
    }
    else if (dayParsed > 31)
    {
        Console.WriteLine("There cannot be more than 31 days in a month try again");
        continue;
    }
    else if (monthParsed > 12)
    {
        Console.WriteLine("There cannot be more than 12 month in a year try again");
        continue ;
    }
    else
    {
        string bday = day + "." + month + "." + year;
        Console.WriteLine(bday);
        AgeCalculator(bday);
        break;
    }
}






