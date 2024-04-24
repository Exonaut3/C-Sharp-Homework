namespace TimeTracker9000.Domain.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        private string Password { get; set; }

        public static void SetPassword(User user, string pass)
        {
            user.Password = pass;
        }
        public static bool PasswordMatch(User user, string password)
        {
            if(user.Password == password)
            {
                return true;
            }
            else { return false; }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"First name: {FirstName}, Last name: {LastName}, Age: {Age}, Username: {Username}");
        }
    }
}
