

static void FormatMaster(string input)
{
    if (input == "1")
    {
        while (true)
        {
            Console.WriteLine("Enter a day for your date");
            string inputDay = Console.ReadLine();
            Console.WriteLine("Enter a month for your date");
            string inputMonth = Console.ReadLine();
            Console.WriteLine("Enter a year for your date");
            string inputYear = Console.ReadLine();

            bool dayValidation = int.TryParse(inputDay, out int parsedDay);
            bool monthValidation = int.TryParse(inputMonth, out int parsedMonth);
            bool yearValidation = int.TryParse(inputYear, out int parsedYear);

            if (!dayValidation || !monthValidation || !yearValidation)
            {
                Console.WriteLine("Invalid input, try again");
                continue;
            }
            else if (parsedDay > 31)
            {
                Console.WriteLine("There cannot be more than 31 days in a month try again");
                continue;
            }
            else if (parsedMonth > 12)
            {
                Console.WriteLine("There cannot be more than 12 month in a year try again");
                continue;
            }
            else if (parsedDay < 0 || parsedMonth < 0 || parsedYear < 0)
            {
                Console.WriteLine("NO NEGATIVES RETARD. TRY AGAIN MONKEYBRAIN");
                continue;
            }
            else
            {
                while (true)
                {
                Console.WriteLine("What kind of format would you like? Choose by inputing the number that corresponds with your desired input");
                    Console.WriteLine("1. MM/dd/yyyy");
                    Console.WriteLine("2. MM.dd.yyyy");
                    Console.WriteLine("3. dddd, dd MMMM yyyy");

                        DateTime date = new DateTime(parsedYear, parsedMonth, parsedDay);
                    string chosenFormat  = Console.ReadLine();
                    if (chosenFormat == "1")
                    {
                        string result = date.ToString("MM/dd/yyyy");
                        Console.WriteLine($"Here is your date \n {result}");
                        break;
                    }
                    else if (chosenFormat == "2")
                    {
                        string result = date.ToString("MM.dd.yyyy");
                        Console.WriteLine($"Here is your date \n {result}");
                        break ;
                    }
                    else if (chosenFormat == "3")
                    {
                        string result = date.ToString("dddd , dd MMMM yyyy");
                        Console.WriteLine($"Here is your date \n {result}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input try again");
                        continue;
                    }
                }

                break;
            }
        }

    }
    else if (input == "2")
    {
        while (true)
        {
            Console.WriteLine("Enter a seconds for your time");
            string inputSeconds = Console.ReadLine();
            Console.WriteLine("Enter a minutes for your date");
            string inputMinutes = Console.ReadLine();
            Console.WriteLine("Enter a hours for your date");
            string inputHours = Console.ReadLine();

            bool secondsValidation = int.TryParse(inputSeconds, out int parsedseconds);
            bool minutesValidation = int.TryParse(inputMinutes, out int parsedMinutes);
            bool hoursValidation = int.TryParse(inputHours, out int parsedHours);

            if (!secondsValidation || !minutesValidation || !hoursValidation)
            {
                Console.WriteLine("Invalid input, try again");
                continue;
            }
            else if(parsedseconds > 60)
            {
                Console.WriteLine("There cannot be more than 60 seconds in a minute. Try again");
                continue;
            }
            else if(parsedMinutes > 60)
            {
                Console.WriteLine("There cannot be more than 60 minutes in an hour. Try again");
                continue;
            }
            else if(parsedHours > 24)
            {
                Console.WriteLine("There cannot be more than 24 hours in a day. Try again");
                continue;
            }
            else if (parsedHours < 0 || parsedMinutes < 0 || parsedseconds < 0)
            {
                Console.WriteLine("NO NEGATIVES RETARD. TRY AGAIN MONKEYBRAIN");
                continue;
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("What kind of format would you like? Choose by inputing the number that corresponds with your desired input");
                    Console.WriteLine("1. hh:mm:ss");
                    Console.WriteLine("2. HH:mm:ss");
                    DateTime date = new DateTime(1,1 ,1, parsedHours, parsedMinutes, parsedseconds);
                    string chosenFormat = Console.ReadLine();
                    if (chosenFormat == "1")
                    {
                        string result = date.ToString("hh:mm:ss");
                        Console.WriteLine($"Here is your time \n {result}");
                        break;

                    }
                    else if (chosenFormat == "2")
                    {
                        string result = date.ToString("HH:mm:ss");
                        Console.WriteLine($"Here is your time \n {result}");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Invalid input try agian");
                        continue;
                    }
               
                }
                break;
            }
        }
       

    }
    else if (input == "3")
    {
        while (true)
        {
            Console.WriteLine("Enter a day for your date");
            string inputDay = Console.ReadLine();
            Console.WriteLine("Enter a month for your date");
            string inputMonth = Console.ReadLine();
            Console.WriteLine("Enter a year for your date");
            string inputYear = Console.ReadLine();

            Console.WriteLine("Enter a seconds for your time");
            string inputSeconds = Console.ReadLine();
            Console.WriteLine("Enter a minutes for your date");
            string inputMinutes = Console.ReadLine();
            Console.WriteLine("Enter a hours for your date");
            string inputHours = Console.ReadLine();


            bool dayValidation = int.TryParse(inputDay, out int parsedDay);
            bool monthValidation = int.TryParse(inputMonth, out int parsedMonth);
            bool yearValidation = int.TryParse(inputYear, out int parsedYear);

            bool secondsValidation = int.TryParse(inputSeconds, out int parsedseconds);
            bool minutesValidation = int.TryParse(inputMinutes, out int parsedMinutes);
            bool hoursValidation = int.TryParse(inputHours, out int parsedHours);

            if (!secondsValidation || !minutesValidation || !hoursValidation || !hoursValidation || !monthValidation || !yearValidation)
            {
                Console.WriteLine("Invalid input, try again");
                continue;
            }
            else if (parsedseconds > 60)
            {
                Console.WriteLine("There cannot be more than 60 seconds in a minute. Try again");
                continue;
            }
            else if (parsedMinutes > 60)
            {
                Console.WriteLine("There cannot be more than 60 minutes in an hour. Try again");
                continue;
            }
            else if (parsedHours > 24)
            {
                Console.WriteLine("There cannot be more than 24 hours in a day. Try again");
                continue;
            }
            else if (parsedDay > 31)
            {
                Console.WriteLine("There cannot be more than 31 days in a month try again");
                continue;
            }
            else if (parsedMonth > 12)
            {
                Console.WriteLine("There cannot be more than 12 month in a year try again");
                continue;
            }
            else if (parsedHours < 0 || parsedMinutes < 0 || parsedseconds < 0 || parsedYear < 0 || parsedMonth < 0 || parsedDay < 0)
            {
                Console.WriteLine("NO NEGATIVES RETARD. TRY AGAIN MONKEYBRAIN");
                continue;
            }
            else
            {
                while (true)
                {

                   
                    Console.WriteLine("What kind of format would you like? Choose by inputing the number that corresponds with your desired input");
                    Console.WriteLine("1. MM/dd/yyyy");
                    Console.WriteLine("2. MM/dd/yyyy hh:mm:ss");
                    Console.WriteLine("3. dddd, dd MMMM yyyy HH:mm:ss");
                    Console.WriteLine("4. MM.dd.yyyy");
                    DateTime date = new DateTime(parsedYear, parsedMonth, parsedDay, parsedHours, parsedMinutes, parsedseconds);
                    string chosenFormat = Console.ReadLine();

                    if (chosenFormat == "1")
                    {
                        string result = date.ToString("MM/dd/yyyy");
                        Console.WriteLine($"Here is your time \n {result}");
                        break;
                    }
                    else if (chosenFormat == "2")
                    {
                        string result = date.ToString("MM/dd/yyyy hh:mm:ss");
                        Console.WriteLine($"Here is your time \n {result}");
                        break;
                    }
                    else if (chosenFormat == "3")
                    {
                        string result = date.ToString("dddd, dd MMMM yyyy HH:mm:ss");
                        Console.WriteLine($"Here is your time \n {result}");
                        break;
                    }
                    else if (chosenFormat == "3")
                    {
                        string result = date.ToString("MM.dd.yyyy");
                        Console.WriteLine($"Here is your time \n {result}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, try again");
                        continue;
                    }
                }
                break;
            }
        }
    }

}

while (true)
{
    Console.WriteLine("Would you like to insert a date, time, or both? (1,2,3)");
    Console.WriteLine("1. Date");
    Console.WriteLine("2. Time");
    Console.WriteLine("3. Both");

     string userInput = Console.ReadLine();
    if ((userInput == "1") || (userInput == "2") || (userInput == "3"))
    {
        FormatMaster(userInput);
        break;
       
    }
    else
    {
        Console.WriteLine("Invalid input try agian");
        continue;
    }
}
