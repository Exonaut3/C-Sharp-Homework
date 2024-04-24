using TimeTracker9000.Domain.Helper;
using TimeTracker9000.Domain.Models;

namespace TimeTracker9000.Domain.Database
{
    
    public abstract class UserDB
    {
        public static User CurrentUser;

        private static List<User> _users = new List<User>();

        public static void AddTestUsers()
        {
            User temp = new User()
            {
                FirstName = "Bob",
                LastName = "Bobski",
                Age = 31,
                Username = "Bobinator1"
            };
            User.SetPassword(temp, "IloveJill123");
            User temp2 = new User()
            {
                FirstName = "Test",
                LastName = "Testerson",
                Age = 24,
                Username = "Testament1"
            };
            User.SetPassword(temp2, "AAAAA1");
            User temp3 = new User()
            {
                FirstName = "Rob",
                LastName = "Robski",
                Age = 31,
                Username = "Robmeister"
            };
            User.SetPassword(temp3, "Ihatebob123");
            _users.Add(temp);
            _users.Add(temp2);
            _users.Add(temp3);
              
        }

        private static List<string> _numberInNamesList = new List<string>() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        private static char[] _arrayOfLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        //chisto za proverka mi e metodava
        public static void ListUsers()
        {
            foreach (var user in _users)
            {
                user.PrintInfo();
            }
        }

        public static bool Login()
        {
            int loginAttempt = 0;
            int loginSuccess = 0;
            Console.Clear();
            while(loginAttempt != 3)
            {
                ExtenderHelper.WriteInColor($"================= LOGIN =================");
                Console.WriteLine("Eneter Username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Enter Password: ");
                string password = Console.ReadLine();
                foreach(var user in  _users)
                {
                    if (user.Username == username && User.PasswordMatch(user, password))
                    {
                       CurrentUser = user;
                        loginSuccess = 1;
                        break;
                    }
                }
                if (loginSuccess == 1)
                {
                    break;
                }
                Console.Clear();
                loginAttempt++;
                ExtenderHelper.WriteInColor($"NO SUCH USERNAME AND PASSWORD COMBINATION, TRY AGAIN \n ({3 - loginAttempt} attemps remaining)", ConsoleColor.Red);
            }
            if(loginSuccess == 1) { return true; }
            else { return false; }

        }

        public static void RegisterUser()
        {
            Console.Clear();

            while (true)
            {
                ExtenderHelper.WriteInColor($"================= REGISTERING USER =================");
                Console.WriteLine("Enter your first name: \n (Cannot contain any numbers)");
                string firstname = Console.ReadLine();
                if(string.IsNullOrEmpty(firstname) || _numberInNamesList.Any(x => firstname.Contains(x)))
                {
                    ExtenderHelper.WriteInError();
                    continue;
                }
                Console.WriteLine("Enter your last name: \n (Cannot contain any numbers)");
                string lastname = Console.ReadLine();
                if (string.IsNullOrEmpty(lastname) || _numberInNamesList.Any(x => lastname.Contains(x)))
                {
                    ExtenderHelper.WriteInError();
                    continue;
                }
                Console.WriteLine("Enter your age \n (Must be over 18)");
                bool ageValidation = int.TryParse(Console.ReadLine(), out int age);
                if (!ageValidation)
                {
                    ExtenderHelper.WriteInError();
                    continue;
                }
                if(age < 18 || age > 120)
                {
                    Console.Clear();
                    ExtenderHelper.WriteInColor("INVALID INPUT, AGE CANNOT BE BELLOW 18 OR OVER 120", ConsoleColor.Red);
                    continue;
                }
                Console.WriteLine("Ente your Username: \n (Must contain at least 5 characters) ");
                string username = Console.ReadLine();
                if (string.IsNullOrEmpty(username))
                {
                    ExtenderHelper.WriteInError();
                    continue;
                }
                if(username.Count() < 5)
                {
                    Console.Clear();
                    ExtenderHelper.WriteInColor("INVALID INPUT, USERNAME CANNOT BE SHORTER THAN 5 CHARACTERS");
                    continue;
                }
                Console.WriteLine("Enter your password: \n (Must be at least 6 characters, contain at least 1 capital letter and 1 number ");
                string password = Console.ReadLine();
                if (string.IsNullOrEmpty(password))
                {
                    ExtenderHelper.WriteInError();
                    continue;
                }
                if(password.Count() < 6)
                {
                    Console.Clear();
                    ExtenderHelper.WriteInColor("INVALID INPUT, PASSWORD IS TOO SHORT", ConsoleColor.Red);
                    continue;
                }
                if(!_arrayOfLetters.Any(x=> password.Contains(x)))
                {
                    Console.Clear();
                    ExtenderHelper.WriteInColor("INVALID INPUT, PASSWORD MUST CONTAIN A CAPITAL LETTER", ConsoleColor.Red);
                    continue;
                }
                if(!_numberInNamesList.Any(x=> password.Contains(x)))
                {
                    Console.Clear();
                    ExtenderHelper.WriteInColor("INVALID INPUT, PASSWORD MUST CONTAIN A NUMBER", ConsoleColor.Red);
                    continue;
                }
                User temp = new User()
                {
                    FirstName = firstname,
                    LastName = lastname,
                    Age = age,
                    Username = username
                };
                User.SetPassword(temp, password);
                _users.Add(temp);

                Console.Clear();
                ExtenderHelper.WriteInColor("NEW USER REGISTERED SUCCESSFULLY", ConsoleColor.Green);
                break;
            }
        }


    }
}
