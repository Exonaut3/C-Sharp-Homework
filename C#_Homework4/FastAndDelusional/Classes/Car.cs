

namespace OhYeahImARacist.Classes
{
    public class Car
    {
        public string Model {  get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }


        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        } 

       public int CalculateSpeed()
        {
            int result = Driver.Skill * Speed;
            return result;
        }


    }
}
