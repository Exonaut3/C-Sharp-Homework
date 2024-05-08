using TimeTracker9000.Domain.Database;
using TimeTracker9000.Domain.Helper;

namespace TimeTracker9000.Services.Services
{
    public static class NameChangerService
    {
        public static void ChangeFirstOrLastName()
        {
            string answer = "";
            while (answer != "x")
            {
                ExtenderHelper.WriteInColor($"================= CHANGING FIRST OR LAST NAME =================");
                Console.WriteLine("What would you like to change?");
                Console.WriteLine("1. Firstname");
                Console.WriteLine("2. Lastname");
                Console.WriteLine("3. Both");
                answer = Console.ReadLine();
                if (answer != "1" && answer != "2" && answer != "3")
                {
                    ExtenderHelper.WriteInError();
                    continue;
                }
                if (answer == "1")
                {
                    Console.Clear();
                    while (true)
                    {
                        Console.WriteLine("Enter your desired Firstname: ");
                        answer = Console.ReadLine();
                        if (!Validator.NameValidation(answer))
                        {
                            continue;
                        }
                        UserDB.CurrentUser.FirstName = answer;
                        break;
                    }
                    answer = "x";
                }
                if (answer == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("Enter your desired Lastname: ");
                        answer = Console.ReadLine();
                        if (!Validator.NameValidation(answer))
                        {
                            continue;
                        }
                        UserDB.CurrentUser.LastName = answer;
                        break;
                    }
                    answer = "x";
                }
                if (answer == "3")
                {
                    while (true)
                    {
                        Console.WriteLine("Enter your desired Firstname: ");
                        answer = Console.ReadLine();
                        if (!Validator.NameValidation(answer))
                        {
                            continue;
                        }
                        UserDB.CurrentUser.FirstName = answer;
                        break;
                    }
                    while (true)
                    {
                        Console.WriteLine("Enter your desired Lastname: ");
                        answer = Console.ReadLine();
                        if (!Validator.NameValidation(answer))
                        {
                            continue;
                        }
                        UserDB.CurrentUser.LastName = answer;
                        break;
                    }
                    answer = "x";
                }


            }
        }

    }
}
