using System.ComponentModel.DataAnnotations;

namespace MyDamn.Domain
{
    public static class PrintInConsole<T>
    {
        public static void Print(T item)
        {
            Console.WriteLine(item);
        }
        public static void PrintColleciton(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}
