using TimeTracker9000.Domain.Database;
using TimeTracker9000.Domain.Helper;
using TimeTracker9000.Domain.Models;

namespace TimeTracker9000.Domain.MainMenu
{
    public static class ChangePassword
    {
        public static bool PasswordChange()
        {
            int attempts = 0;
            string password = "";
            while (attempts != 3)
            {
                ExtenderHelper.WriteInColor($"================= CHANGING PASSWORD =================");
                Console.WriteLine("Enter Old password to confirm user: ");
                password = Console.ReadLine();
                if(password != User.ReturnPassword())
                {
                    Console.Clear();
                    attempts++;
                    ExtenderHelper.WriteInColor($"THE PASSWORD DOES NOT MATCH \n(Attempts remaining {attempts - 3})", ConsoleColor.Red);
                    continue;
                }
                else
                {
                    break;
                }
                
            }
            while (attempts != 3)
            {
                ExtenderHelper.WriteInColor($"================= CHANGING PASSWORD =================");
                Console.WriteLine("Enter new password: ");
                string newPass = Console.ReadLine();
                if (!Validator.PasswordValidation(newPass))
                {
                    continue;
                }
                else
                {
                    User.SetPassword(UserDB.CurrentUser, newPass);
                    Console.Clear();
                    ExtenderHelper.WriteInColor($"PASSWORD CHANGED SUCCESSFULLY!", ConsoleColor.Green);
                    break;
                }

            }
            if (attempts == 3)
            {
                ExtenderHelper.WriteInColor($"TOO MANY ATTEMPTS, THE APP WILL NOW SHUT DOWN");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
