namespace TimeTracker9000.Domain.Helper
{
    public static class ExtenderHelper
    {
        private static List<string> _numberInNamesList = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };


        public static void WriteInColor(string text, ConsoleColor color = ConsoleColor.Cyan)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();

        }

       public static void WriteInError()
        {
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("INVALID INPUT, TRY AGAIN");
            Console.ResetColor();
        }

    }
}
