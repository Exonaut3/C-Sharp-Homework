using TimeTracker9000.Domain.Database;
using TimeTracker9000.Domain.Helper;
using TimeTracker9000.Domain.Models;

UserDB.AddTestUsers();

ExtenderHelper.WriteInColor($"WELCOME TO THE TIME TRACKER 9000", ConsoleColor.Blue);

string answer;
bool loginSuccess = false;
while (true)
{
ExtenderHelper.WriteInColor($"================= MENU =================");
    Console.WriteLine("1. Login");
    Console.WriteLine("2. Register");
    Console.WriteLine("3. Print Userinfo");

    answer = Console.ReadLine();
    if (answer != "1" &&  answer != "2" && answer != "3")
    {
        ExtenderHelper.WriteInError();
        continue;
    }
    if(answer == "1")
    {
        if (!UserDB.Login())
        {
            ExtenderHelper.WriteInColor("TOO MANY LOGIN ATTEMPS, THE APP WILL NOW SHUT DOWN", ConsoleColor.Red);
            break;
        }
        else
        {
            loginSuccess = true;
            break;
        }
    }

    if(answer == "2")
    {
        UserDB.RegisterUser();
    }

    if (answer == "3")
    {
        Console.Clear();
        ExtenderHelper.WriteInColor($"================= PRINTING USER INFO =================");
        UserDB.ListUsers();
    }
}

ExtenderHelper.WriteInColor($"================= WELCOME {UserDB.CurrentUser.FirstName} {UserDB.CurrentUser.LastName}  =================");
while (true)
{
    ExtenderHelper.WriteInColor($"================= USER MENU =================");

    Console.WriteLine("1. Track");
    Console.WriteLine("2. Change password");
    Console.WriteLine("3. Print Userinfo");
}

