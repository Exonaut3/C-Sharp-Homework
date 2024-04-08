using Zoo.Domain.Models.BaseModel;

namespace Zoo.Domain.Generics
{
    public class PetStore<T> where T : Pet
    {
        public List<T> ListOfPets = new List<T>();
        public void PrintsPets()
        {
            foreach (T pet in ListOfPets)
            {
                pet.PrintInfo();
            }
        }
        public void BuyPet(string name)
        {
            Pet pet = ListOfPets.SingleOrDefault(x => x.Name == name);
            if (pet != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The {pet.GetType().Name} {pet.Name} has been successfully bought! CONGRATULATIONS!!!");
                ListOfPets.Remove((T)pet);          //IMPORTANT! This really messed me up. 
                //                 ^^^^^^  sigurno ima nekoj bolje nachin da se napravi ova ali ne go znam :((((
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Sorry, unfortunately we don't have a pet that goes by the name {name} :(((");
                Console.ResetColor ();
            }
        }
        public PetStore()
        {

        }
    }
}
