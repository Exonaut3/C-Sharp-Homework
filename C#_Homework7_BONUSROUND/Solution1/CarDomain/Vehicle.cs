

namespace CarDomain
{
    public abstract class Vehicle
    {
        public abstract void DisplayInfo();

        public void Drive()
        {
            Console.WriteLine("The car is driving");
        }

        public void Wheelie()
        {
            Console.WriteLine("The motorbike is driving on one wheel");
        }

        public void Sail()
        {
            Console.WriteLine("The boat is sailing");
        }
        public void Fly()
        {
            Console.WriteLine("The airplane is flying");
        }
    }


}
