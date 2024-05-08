using TimeTracker9000.Domain.Database;
using TimeTracker9000.Domain.Database.Activities;
using TimeTracker9000.Domain.Database.Activities.ActivityEnums;
using TimeTracker9000.Domain.Helper;

namespace TimeTracker9000.Domain.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public bool ActiveAccount = true;
        public string Password { get; set; }
        public List<Reading> Reading = new List<Reading>();
        public List<Exercising> Exercising = new List<Exercising>();
        public List<Working> Working = new List<Working>();
        public List<Other> Other = new List<Other>();


        public static string ReturnPassword()
        {
            return UserDB.CurrentUser.Password;

        }


        public static void SetPassword(User user, string pass)
        {
            user.Password = pass;
        }
        public static bool PasswordMatch(User user, string password)
        {
            if (user.Password == password)
            {
                return true;
            }
            else { return false; }
        }



        public void PrintInfo()
        {
            Console.WriteLine($"First name: {FirstName}, Last name: {LastName}, Age: {Age}, Username: {Username}");
        }

        public void UserStats()
        {
            double totalTimeSpentInHours = 0;
            double averageTimeSpent = 0;
            int totalNumberOfPagesRead = 0;
            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;
            double max = 0;

            foreach (Reading readings in Reading)
            {
                totalTimeSpentInHours += readings.TimeSpent / 60;
                averageTimeSpent += readings.TimeSpent;
                totalNumberOfPagesRead += readings.NumberOfPages;
                if (readings.TypeOfReading == ReadingTypes.BellesLettres)
                {
                    counter1++;
                }
                if (readings.TypeOfReading == ReadingTypes.Fiction)
                {
                    counter2++;
                }
                if (readings.TypeOfReading == ReadingTypes.ProfessionalLiterature)
                {
                    counter3++;
                }
            }
            averageTimeSpent = averageTimeSpent / Reading.Count;
            ExtenderHelper.WriteInColor("======= READING =======", ConsoleColor.Yellow);
            Console.WriteLine($"Total time in hours: {totalTimeSpentInHours:0.00}H");
            Console.WriteLine($"Average time spent reading: {averageTimeSpent:0.00} minutes");
            Console.WriteLine($"Total number of pages read: {totalNumberOfPagesRead:0.00}");
            max = Math.Max(counter1, Math.Max(counter2, counter3));
            if (max == null)
            {
                Console.WriteLine("You don't have a single favorite genre");
            }
            if (max == counter1)
            {
                Console.WriteLine("Your favorite genre is Belles Lattres");
            }
            if (max == counter2)
            {
                Console.WriteLine("Your favorite genre is Ficiton");
            }
            if (max == counter3)
            {
                Console.WriteLine("Your favorite genre is Proffesional Reading");
            }


            totalTimeSpentInHours = 0;
            averageTimeSpent = 0;
            counter1 = 0;
            counter2 = 0;
            counter3 = 0;
            foreach (Exercising exercisings in Exercising)
            {
                totalTimeSpentInHours += exercisings.TimeSpent / 60;
                averageTimeSpent += exercisings.TimeSpent;
                if (exercisings.TypeOfExercise == ExerciseTypes.General)
                {
                    counter1++;
                }
                if (exercisings.TypeOfExercise == ExerciseTypes.Running)
                {
                    counter2++;
                }
                if (exercisings.TypeOfExercise == ExerciseTypes.Sport)
                {
                    counter3++;
                }
            }
            ExtenderHelper.WriteInColor("======= EXERCISING =======", ConsoleColor.Yellow);
            Console.WriteLine($"Total time in hours: {totalTimeSpentInHours:0.00}H");
            Console.WriteLine($"Average time spent exercising: {averageTimeSpent:0.00} minutes");
            max = Math.Max(counter1, Math.Max(counter2, counter3));
            if (max == null)
            {
                Console.WriteLine("You don't have a single favorite type of exercise");
            }
            if (max == counter1)
            {
                Console.WriteLine("Your favorite type of exercise is General");
            }
            if (max == counter2)
            {
                Console.WriteLine("Your favorite type of exercise is Running");
            }
            if (max == counter3)
            {
                Console.WriteLine("Your favorite type of exercise is Sport");
            }


            totalTimeSpentInHours = 0;
            averageTimeSpent = 0;
            counter1 = 0;
            counter2 = 0;
            counter3 = 0;
            foreach (Working workings in Working)
            {
                totalTimeSpentInHours += workings.TimeSpent / 60;
                averageTimeSpent += workings.TimeSpent;
                if (workings.Place == WorkingTypes.AtWork)
                {
                    counter1 += workings.TimeSpent;
                }
                else
                {
                    counter2 += workings.TimeSpent;
                }
            }
            ExtenderHelper.WriteInColor("======= WORKING =======", ConsoleColor.Yellow);
            Console.WriteLine($"Total time in hours: {totalTimeSpentInHours:0.00}H");
            Console.WriteLine($"Average time spent working: {averageTimeSpent:0.00} minutes");
            Console.WriteLine($"Time spent working at Work: {counter1:0.00}");
            Console.WriteLine($"Time spent working at Home: {counter2:0.00}");

            totalTimeSpentInHours = 0;
            averageTimeSpent = 0;
            counter1 = 0;
            counter2 = 0;
            counter3 = 0;

            foreach (Other others in Other)
            {
                totalTimeSpentInHours += others.TimeSpent / 60;
            }
            List<string> hobbyNames = Other.Select(x => x.Title).Distinct().ToList();

            ExtenderHelper.WriteInColor("======= OTHER =======", ConsoleColor.Yellow);
            Console.WriteLine($"Total time in hours: {totalTimeSpentInHours:0.00}H");
            Console.WriteLine("Hobbies: ");
            foreach (string name in hobbyNames)
            {
                Console.WriteLine(name);
            }

        }
    }
}
