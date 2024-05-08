using TimeTracker9000.Domain.Database;
using TimeTracker9000.Domain.Helper;

namespace TimeTracker9000.Domain.Domain
{
    public static class AccountDeactivation
    {
        public static bool DeactivateAccount()
        {
            string answer;
            while (true)
            {
                Console.WriteLine("Are you sure you want to deactivate your account? (Y/N)");
                answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                {
                    UserDB.CurrentUser.ActiveAccount = false;
                    UserDB.CurrentUser = null;
                    ExtenderHelper.WriteInColor($"USER {UserDB.CurrentUser.Username} HAS BEEN DEACTIVATED", ConsoleColor.Red);
                    return false;
                }
                if (answer.ToLower() == "n")
                {
                    return true;
                }
                else
                {
                    Console.Clear();
                    ExtenderHelper.WriteInError();
                }
            }

        }
    }
}
