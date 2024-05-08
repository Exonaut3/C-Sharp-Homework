using TimeTracker9000.Domain.Database;
using TimeTracker9000.Domain.Helper;

namespace TimeTracker9000.Domain.Helper
{
    public static class Validator
    {
        private static List<string> _numberInNamesList = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        private static char[] _arrayOfLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        public static bool NumberValidator(string number)
        {
            if (int.TryParse(number, out int parsedNumber))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public static bool NameValidation(string name)
        {
            if(string.IsNullOrEmpty(name) || _numberInNamesList.Any(x => name.Contains(x)) || name.Count() < 2)
            {
                ExtenderHelper.WriteInError();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int AgeValidation(string age)
        {
            bool ageValidation = int.TryParse(age, out int result);
            if(!ageValidation)
            {
                Console.Clear();
                ExtenderHelper.WriteInColor("INVALID INPUT, NOT A NUMBER, TRY AGAIN", ConsoleColor.Red);
                return -1;
            }
            else if(result < 18 || result > 120)
            {
                Console.Clear();
                ExtenderHelper.WriteInColor("INVALID INPUT, AGE CANNOT BE UNDER 18 AND OVER 120", ConsoleColor.Red);
                return -1;
            }
            else
            {
                return result;
            }

        }

        public static bool UsernameValidation(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                ExtenderHelper.WriteInError();
                return false;
            }
            else if (username.Count() < 5)
            {
                Console.Clear();
                ExtenderHelper.WriteInColor("INVALID INPUT, USERNAME CANNOT BE SHORTER THAN 5 CHARACTERS", ConsoleColor.Red);
                return false;
            }
            else if (UserDB.UserCycle().Any(x=> x.Username == username))
            {
                Console.Clear();
                ExtenderHelper.WriteInColor("INVALID INPUT, THERE IS ALREADY A USER WITH THAT USERNAME", ConsoleColor.Red);
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool PasswordValidation(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                ExtenderHelper.WriteInError();
                return false;
            }
            else if (password.Count() < 6)
            {
                Console.Clear();
                ExtenderHelper.WriteInColor("INVALID INPUT, PASSWORD IS TOO SHORT", ConsoleColor.Red);
                return false;

            }
            else if(!_arrayOfLetters.Any(x => password.Contains(x)))
            {
                Console.Clear();
                ExtenderHelper.WriteInColor("INVALID INPUT, PASSWORD MUST CONTAIN A CAPITAL LETTER", ConsoleColor.Red);
                return false;

            }
            else if(!_numberInNamesList.Any(x => password.Contains(x)))
            {
                Console.Clear();
                ExtenderHelper.WriteInColor("INVALID INPUT, PASSWORD MUST CONTAIN A NUMBER", ConsoleColor.Red);
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}
