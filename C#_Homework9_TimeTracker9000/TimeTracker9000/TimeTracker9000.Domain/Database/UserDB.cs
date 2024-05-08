using Newtonsoft.Json;
using System;
using TimeTracker9000.Domain.Helper;
using TimeTracker9000.Domain.MainMenu.The_Tracker.Activities;
using TimeTracker9000.Domain.MainMenu.The_Tracker.Activities.ActivityEnums;
using TimeTracker9000.Domain.Models;

namespace TimeTracker9000.Domain.Database
{
    
    public abstract class UserDB
    {
        public static User CurrentUser;

        private static List<User> _users = new List<User>();

        public static void SerializeDatabase()
        {
            string directoryPath = @"..\..\..\Data";
            string filePath = directoryPath +  @"\Users.txt";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
                string userSerialized = JsonConvert.SerializeObject(_users);
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(userSerialized);
                }
           
        }
        public static void LoadUsers()
        {
            string directoryPath = @"..\..\..\Data";
            string filePath = directoryPath + @"\Users.txt";
                using (StreamReader sr = new StreamReader(filePath))
                {
                    List<User> tempUser = JsonConvert.DeserializeObject<List<User>>(sr.ReadToEnd());
                    _users = tempUser; 
                }
            
        }
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

        public static List<User> UserCycle()
        {
            return _users;
        }

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
        public static void AddActivities()
        {
            foreach(User user in _users)
            {
                user.Reading.Add(new Reading()
                {
                    TimeSpent = new Random().NextDouble() * 100,
                    NumberOfPages = new Random().Next(1,300),
                    TypeOfReading = ReadingTypes.ProfessionalLiterature
                    
                });
                user.Exercising.Add(new Exercising()
                {
                    TimeSpent = new Random().NextDouble() * 100,
                    TypeOfExercise = ExerciseTypes.Running
                });
                user.Working.Add(new Working()
                {
                    TimeSpent = new Random().NextDouble() * 100,
                    Place = WorkingTypes.AtWork
                });
                user.Other.Add(new Other()
                {
                    Title = "lmao" +  new Random().Next(1,2).ToString(),
                    TimeSpent = new Random().NextDouble() * 100,

                });
            }
        }
        public static void AddActivitiesRNG()
        {
            foreach(User user in _users)
            {
                while(new Random().Next(1,100) > 50)
                {
                    if (new Random().Next(1, 3) == 1)
                    {
                        user.Reading.Add(new Reading()
                        {
                            TimeSpent = new Random().NextDouble() * 100,
                            NumberOfPages = new Random().Next(1, 300),
                            TypeOfReading = ReadingTypes.BellesLettres

                        });
                    }
                    else
                    {
                        if(new Random().Next(2,4) == 2)
                        {
                            user.Reading.Add(new Reading()
                            {
                                TimeSpent = new Random().NextDouble() * 100,
                                NumberOfPages = new Random().Next(1, 300),
                                TypeOfReading = ReadingTypes.Fiction

                            });
                        }
                        else
                        {
                            user.Reading.Add(new Reading()
                            {
                                TimeSpent = new Random().NextDouble() * 100,
                                NumberOfPages = new Random().Next(1, 300),
                                TypeOfReading = ReadingTypes.ProfessionalLiterature

                            });
                        }
                    }
                   
                }
                while (new Random().Next(1, 100) > 50)
                {
                    if(new Random().Next(1,3) == 1)
                    {
                        user.Exercising.Add(new Exercising()
                        {
                            TimeSpent = new Random().NextDouble() * 100,
                            TypeOfExercise = ExerciseTypes.General
                        });
                    }
                    else
                    {
                        if(new Random().Next(2,4) == 2)
                        {
                            user.Exercising.Add(new Exercising()
                            {
                                TimeSpent = new Random().NextDouble() * 100,
                                TypeOfExercise = ExerciseTypes.Running
                            });
                        }
                        else
                        {
                            user.Exercising.Add(new Exercising()
                            {
                                TimeSpent = new Random().NextDouble() * 100,
                                TypeOfExercise = ExerciseTypes.Sport
                            });
                        }


                    }

                }
                while (new Random().Next(1, 100) > 50)
                {
                    if (new Random().Next(1, 3) == 1)
                    {
                        user.Working.Add(new Working()
                        {
                            TimeSpent = new Random().NextDouble() * 100,
                            Place = WorkingTypes.AtWork
                        });
                    }
                    else
                    {
                        user.Working.Add(new Working()
                        {
                            TimeSpent = new Random().NextDouble() * 100,
                            Place = WorkingTypes.FromHome
                        });
                    }
                   
                }
                while (new Random().Next(1, 100) > 50)
                {
                   
                    user.Other.Add(new Other()
                    {
                        Title = "lmao" + new Random().Next(1, 3).ToString(),
                        TimeSpent = new Random().NextDouble() * 100,
                    }); 
                }

            }
        }

    
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
            int noActivation = 0;
            string answer;
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
                        if(user.ActiveAccount == false)
                        {
                            while (true)
                            {
                                Console.WriteLine("Would you like to reactivate your account? (Y/N)");
                                answer = Console.ReadLine();
                                if(answer.ToLower() == "y")
                                {
                                    user.ActiveAccount = true;
                                    CurrentUser = user;
                                    loginSuccess = 1;
                                    break;
                                }
                                else if (answer.ToLower() == "n")
                                {
                                    loginSuccess = 1;
                                    noActivation = 1;
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    ExtenderHelper.WriteInError();
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            CurrentUser = user;
                            loginSuccess = 1;
                        }
                        break;
                    }
                }
                if (loginSuccess == 1)
                {
                    break;
                }
                Console.Clear();
                loginAttempt++;
                ExtenderHelper.WriteInColor($"NO SUCH USERNAME AND PASSWORD COMBINATION \n({3 - loginAttempt} attemps remaining)", ConsoleColor.Red);
            }
            if (loginSuccess == 1 && noActivation == 1) { Console.Clear(); return false; }
            else if (loginSuccess == 1) { return true; }
            else { return false; }

        }

        public static void RegisterUser()
        {
            Console.Clear();

            while (true)
            {
                ExtenderHelper.WriteInColor($"================= REGISTERING USER =================");
                Console.WriteLine("Enter your first name: \n (Cannot contain any numbers and cannot be shorter than 2 characters)");
                string firstname = Console.ReadLine();
                if(!Validator.NameValidation(firstname))  
                {
                    continue;
                }
                Console.WriteLine("Enter your last name: \n (Cannot contain any numbers and cannot be shorter than 2 characters)");
                string lastname = Console.ReadLine();
                if (!Validator.NameValidation(lastname))
                {
                    continue;
                }
                Console.WriteLine("Enter your age \n (Must be over 18)");
                int age = Validator.AgeValidation(Console.ReadLine());
                if (age == -1)
                {
                    continue;
                }
                Console.WriteLine("Ente your Username: \n (Must contain at least 5 characters) ");
                string username = Console.ReadLine();
                if (!Validator.UsernameValidation(username))
                {
                    continue;
                }
                Console.WriteLine("Enter your password: \n (Must be at least 6 characters, contain at least 1 capital letter and 1 number ");
                string password = Console.ReadLine();
                if (!Validator.PasswordValidation(password))
                {
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
                if (answer != "1" &&  answer != "2" && answer != "3")
                {
                    ExtenderHelper.WriteInError();
                    continue;
                }
                if(answer == "1")
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
                if(answer == "2")
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
                if(answer == "3")
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
