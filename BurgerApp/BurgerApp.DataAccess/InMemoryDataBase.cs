using BurgerApp.Domain;

namespace BurgerApp.DataAccess
{
    public static class InMemoryDataBase
    {
        public static List<Burger> Burgers { get; set; }
        public static int NumberOfOrdersServiced { get; set; }
        public static List<Order> ListOfOrders { get; set; }
        public static double AveragePriceOfAnOrder { get; set; }
        public static Burger MostPurchasedBurger;


        static InMemoryDataBase()
        {
            LoadBurgers();
            LoadListOfOrders();
            NumberOfOrdersServiced = ListOfOrders.Where(x=> x.IsDelivered == true).Count();
            AveragePriceOfAnOrder = CalculateAveragePriceOfAnOrder();
            MostPurchasedBurger = ReturnMostPurchasedBurger();
        }
        public static void LoadBurgers()
        {
            Burgers = new List<Burger>()
            {
                new Burger(1,"The False Prophet", 8, false, false, false),
                new Burger(2, "The Vegeterian Viscount", 5.2, true, true, true),
                new Burger(3, "The Salmonela Sovereign", 5, false, false, true),
                new Burger(4, "The Sensitive Saer", 3.5, true, false, false),
                new Burger(5, "The Master Of Morality", 4.3, true, true, false),
            };
        }

        public static void LoadListOfOrders()
        {
            Console.WriteLine(Burgers[1]);
            ListOfOrders = new List<Order>()
            {
                
                new Order(1,"Ryan Gosling", "Hollywood Hills #5", true, new List<Burger>(){Burgers[0], Burgers[0], Burgers[2] }, "Mainland China"),
                new Order(2,"The Driver", "Downtown Hood St. #12", false, new List<Burger>(){Burgers[0]}, "California"),
                new Order(3,"The Stuntman", "Also Hollywood", true, new List<Burger>(){Burgers[1], Burgers[3] }, "Hollywood"),
                new Order(4,"Ken, From Barbie", "Barbie Land", false, new List<Burger>(){Burgers[3], Burgers[1], Burgers[4], Burgers[4], Burgers[0] }, "Barbie Land")
            };
        }

        public static double CalculateAveragePriceOfAnOrder()
        {
            //List<double> listOfAveragePrices = (List<double>)ListOfOrders.Select(x => x.Burgers.Select(x => x.Price));
            //double result = listOfAveragePrices.Average();

            //Couldn't find a better way of doing this sadly...
            double result = 0;
            foreach (Order order in ListOfOrders)
            {
                double orderPrice = order.Burgers.Select(x => x.Price).Sum();
                result += orderPrice;
            }
            return result / ListOfOrders.Count();
        }

        public static Burger ReturnMostPurchasedBurger()
        {
            //feeling real stupid again
            List<Burger> listOfBurgers = new List<Burger>();
            foreach (Order order in ListOfOrders)
            {
                foreach (Burger burger in order.Burgers)
                {
                    listOfBurgers.Add(burger);
                }
            }
            List<int> listOfBurgersIds = listOfBurgers.Select(x=>x.Id).ToList();
            int idOfMostPurchasedBurger = listOfBurgersIds.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
            return Burgers.FirstOrDefault(x=> x.Id == idOfMostPurchasedBurger);
        }
    }
}
