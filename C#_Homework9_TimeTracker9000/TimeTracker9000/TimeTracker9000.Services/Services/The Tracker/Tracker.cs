using TimeTracker9000.Domain.Database;
using TimeTracker9000.Domain.Database.Activities;
using TimeTracker9000.Domain.Database.Activities.ActivityEnums;
using TimeTracker9000.Domain.Helper;

namespace TimeTracker9000.Domain.The_Tracker
{
    public static class Tracker
    {
        public static void Track()
        {
            DateTime start;
            DateTime end;
            string answer = "";
            string innerChoice = "";
            string confirmer;
            int pagesRead;
            while(answer.ToLower() != "x")
            {
                while (answer.ToLower() != "x")
                {
                    ExtenderHelper.WriteInColor($"================= ACTIVITIES MENU =================");
                    Console.WriteLine("What Activity would you like to keep track?");
                    Console.WriteLine(@"Press ""X"" to exit");
                    Console.WriteLine("1. Reading");
                    Console.WriteLine("2. Exercising");
                    Console.WriteLine("3. Work");
                    Console.WriteLine("4. Other");
                    answer = Console.ReadLine();
                    if (answer != "1" && answer != "2" && answer != "3" && answer != "4" && answer.ToLower() != "x")
                    {
                        Console.Clear();
                        ExtenderHelper.WriteInError();
                        continue;
                    }
                    break;
                }
                if(answer.ToLower() == "x")
                {
                    Console.Clear();

                    break;
                }
                Console.WriteLine("Activity selected. Press key to begin.");
                confirmer = Console.ReadKey().ToString();
                start = DateTime.Now;
                ExtenderHelper.WriteInColor($"\nTracking has begun! Activity started at {start.Hour}:{start.Minute}:{start.Second}", ConsoleColor.Green);
                Console.WriteLine("Press ENTER to stop tracking");
                confirmer = Console.ReadLine();
                end = DateTime.Now;
                double timeSpent = (end - start).TotalMinutes;
                if (answer == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("Enter the number of pages you have read: ");
                        answer = Console.ReadLine();
                        if (!Validator.NumberValidator(answer))
                        {
                            Console.Clear();
                            ExtenderHelper.WriteInError();
                            continue;
                        }
                        pagesRead = int.Parse(answer);
                        break;
                    }
                    while (true)
                    {
                        Console.WriteLine("What kind of genre was it: ");
                        Console.WriteLine("1. Belles Lettres");
                        Console.WriteLine("2. Fiction");
                        Console.WriteLine("3. Professional Literature");
                        innerChoice = Console.ReadLine();
                        if (innerChoice != "1" && innerChoice != "2" && innerChoice != "3")
                        {
                            Console.Clear();
                            ExtenderHelper.WriteInError();
                            continue;
                        }
                        if (innerChoice == "1")
                        {
                            UserDB.CurrentUser.Reading.Add(new Reading()
                            {
                                TimeSpent = timeSpent,
                                NumberOfPages = pagesRead,
                                TypeOfReading = ReadingTypes.BellesLettres
                            });
                        }
                        else if (innerChoice == "2")
                        {
                            UserDB.CurrentUser.Reading.Add(new Reading()
                            {
                                TimeSpent = timeSpent,
                                NumberOfPages = pagesRead,
                                TypeOfReading = ReadingTypes.Fiction
                            });
                        }
                        else if (innerChoice == "3")
                        {
                            UserDB.CurrentUser.Reading.Add(new Reading()
                            {
                                TimeSpent = timeSpent,
                                NumberOfPages = pagesRead,
                                TypeOfReading = ReadingTypes.ProfessionalLiterature
                            });
                        }
                        Console.WriteLine($"You have spent {timeSpent:0.00} minutes Reading");
                        break;
                    }
                }
                if (answer == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("What type of exercise did you do?");
                        Console.WriteLine("1. General");
                        Console.WriteLine("2. Running");
                        Console.WriteLine("3. Sport");
                        innerChoice  = Console.ReadLine();
                        if (innerChoice != "1" && innerChoice != "2" && innerChoice != "3")
                        {
                            Console.Clear();
                            ExtenderHelper.WriteInError();
                            continue;
                        }
                        if (innerChoice == "1")
                        {
                            UserDB.CurrentUser.Exercising.Add(new Exercising()
                            {
                                TimeSpent = timeSpent,
                                TypeOfExercise = ExerciseTypes.General
                            });
                        }
                        if (innerChoice == "2")
                        {

                            UserDB.CurrentUser.Exercising.Add(new Exercising()
                            {
                                TimeSpent = timeSpent,
                                TypeOfExercise = ExerciseTypes.Running
                            });
                        }
                        if (innerChoice == "3")
                        {

                            UserDB.CurrentUser.Exercising.Add(new Exercising()
                            {
                                TimeSpent = timeSpent,
                                TypeOfExercise = ExerciseTypes.Sport
                            });
                        }
                        Console.WriteLine($"You have spent {timeSpent:0.00} minutes Exercising");
                        break;
                    }
                }
                if (answer == "3")
                {
                    while (true)
                    {
                        Console.WriteLine("Where did you work?");
                        Console.WriteLine("1. At work");
                        Console.WriteLine("2. At home");
                        innerChoice = Console.ReadLine();
                        if (innerChoice != "1" && innerChoice != "2")
                        {
                            Console.Clear();
                            ExtenderHelper.WriteInError();
                            continue;
                        }
                        if (innerChoice == "1")
                        {
                            UserDB.CurrentUser.Working.Add(new Working()
                            {
                                TimeSpent = timeSpent,
                                Place = WorkingTypes.AtWork
                            });
                        }
                        else
                        {
                            UserDB.CurrentUser.Working.Add(new Working()
                            {
                                TimeSpent = timeSpent,
                                Place = WorkingTypes.FromHome
                            });
                        }
                        Console.WriteLine($"You have spent {timeSpent:0.00} minutes Working");
                        break;
                    }
                }
                if (answer == "4")
                {
                    Console.WriteLine("Enter the name of your activity: ");
                    answer = Console.ReadLine();
                    UserDB.CurrentUser.Other.Add(new Other()
                    {
                        Title = answer
                    });
                    Console.WriteLine($"You have spent {timeSpent:0.00} minutes on {answer}");
                }
                break;

            }



        }
    }
}
