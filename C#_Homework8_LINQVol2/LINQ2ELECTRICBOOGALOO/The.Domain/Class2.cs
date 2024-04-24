namespace The.Domain
{
    public static class Helper<T> where T : Car
    {
        public static void CarReader(List<T> list)
        {
            foreach (T item in list)
            {
                item.PrintInfo();
            }
        }

        public static void WriteInColor(string text, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

    }
    public static class RegularHelper<T>
    {

        public static void RegularReader(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
           
        }



    }
}
