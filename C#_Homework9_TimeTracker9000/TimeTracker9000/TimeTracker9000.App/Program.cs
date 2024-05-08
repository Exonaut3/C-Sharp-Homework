using TimeTracker9000.Domain.Database;
using TimeTracker9000.Domain.Domain;
using TimeTracker9000.Domain.Helper;
using TimeTracker9000.Domain.The_Tracker;
using TimeTracker9000.Services.Services;

//UserDB.AddTestUsers();
//UserDB.AddActivities();
//UserDB.AddActivitiesRNG();
//UserDB.SerializeDatabase(); /*ovie gi koristev za test database da napravam, sega samo load users e potrebno i ponatamu serializeatabase */
UserDB.LoadUsers();
ExtenderHelper.WriteInColor($"WELCOME TO THE TIME TRACKER 9000", ConsoleColor.Blue);

string answer;
bool loginSuccess = false;
bool maxAttemps = true;

while (maxAttemps)
{
    while (true)
    {
        ExtenderHelper.WriteInColor($"================= LOGIN MENU =================");
        Console.WriteLine("1. Login");
        Console.WriteLine("2. Register");
        Console.WriteLine("3. Print Userinfo");

        answer = Console.ReadLine();
        if (answer == "1")
        {
            if (!UserDB.Login())
            {
                ExtenderHelper.WriteInColor("TOO MANY LOGIN ATTEMPS, THE APP WILL NOW SHUT DOWN", ConsoleColor.Red);
                break;
            }
            else
            {
                loginSuccess = true;
                UserDB.SerializeDatabase();
                break;
            }
        }
        else if (answer == "2")
        {
            UserDB.RegisterUser();
            UserDB.SerializeDatabase();

        }
        else if (answer == "3")
        {
            Console.Clear();
            ExtenderHelper.WriteInColor($"================= PRINTING USER INFO =================");
            UserDB.ListUsers();
        }
        else
        {
            ExtenderHelper.WriteInError();
            continue;
        }
    }
    if (!loginSuccess)
    {
        break;
    }
    Console.Clear();
    ExtenderHelper.WriteInColor($"================= WELCOME {UserDB.CurrentUser.FirstName} {UserDB.CurrentUser.LastName}  =================");
    while (loginSuccess == true)
    {
        ExtenderHelper.WriteInColor($"================= MAIN MENU =================");

        Console.WriteLine("1. Track");
        Console.WriteLine("2. Change password");
        Console.WriteLine("3. Change First and Last name");
        Console.WriteLine("4. User Statistics");
        Console.WriteLine("5. Deactivate account");
        Console.WriteLine("6. Log out");
        answer = Console.ReadLine();
        if (answer == "1")
        {
            Console.Clear();
            Tracker.Track();
            UserDB.SerializeDatabase();
            continue;
        }
        else if (answer == "2")
        {
            Console.Clear();
            maxAttemps = ChangePassword.PasswordChange();
            if (!maxAttemps)
            {
                break;
            }

            UserDB.SerializeDatabase();
        }
        else if (answer == "3")
        {
            Console.Clear();
            NameChangerService.ChangeFirstOrLastName();             // ova go napraviv pred da vidam delot sto mi vika treba se da piknam vo account managment :((((
            UserDB.SerializeDatabase();
            continue;
        }
        else if (answer == "4")
        {
            Console.Clear();
            UserDB.CurrentUser.UserStats();            //avtomatski vrakja nazad
            continue;
        }
        else if (answer == "5")
        {
            Console.Clear();
            loginSuccess = AccountDeactivation.DeactivateAccount();  //na somnitelno mesto ja deklarirav metodava
            UserDB.SerializeDatabase();
        }
        else if (answer == "6")
        {
            Console.Clear();
            ExtenderHelper.WriteInColor($"User {UserDB.CurrentUser.Username} is logged out", ConsoleColor.Yellow);
            UserDB.CurrentUser = null;
            loginSuccess = false;
        }
        else
        {
            ExtenderHelper.WriteInError();
            continue;
        }
    }

}



//===================CLOSING COMMENTS============================
//Arhitekturata mi smrdi, tuka nema diskusija
//Izbrzan beshe posledniot del (part 2 i part 3)
// Funkcionalno se si raboti 
//Golema maana mi e shto ne uspeav da se zadrzham za password da mi e so protected keyword
//Bidejki nemashe kako da go serijaliziram i zachuvam vo databazata
//Ali ne sum na cybersecurity zatoa, it is what it is
//povekjeto stvari se vo userDB

//Edit:
//Pri optimizacija mislam deka indirektno primeniv mnogu "Piggybacking" 
//ne sakashe da mi funkcionira bez toa