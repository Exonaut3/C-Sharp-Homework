using OhYeahImARacist.Classes;

Driver ryanGosling = new Driver("Ryan Gosling (me)", 999);
Driver murat = new Driver("Murat", 70);
Driver radica = new Driver("Radica", 50);
Driver maxVerstappen = new Driver("Max Verstappen", 95);

Car fordKuga = new Car("Ford: Kuga", 200);
Car mercedes = new Car("Mercedes: idk nekoj so avtomatik", 150);
Car seat = new Car("Seat: toj na Radica", 135);
Car literalFormula1 = new Car("Literal F1 (it has redbull logos)", 375);

Car[] carArray = {fordKuga, seat, literalFormula1, mercedes};
Driver[] driverArray = {ryanGosling, murat, radica, maxVerstappen};

string response = "";

 void RaceCars()
{

    while (true)
    {

        Console.WriteLine("Select the first car from the list of cars (use numbers)");
        for (int i = 0; i < carArray.Length; i++)
        {
            Console.WriteLine($"{i+1}. {carArray[i].Model}");
        }
        bool validation = int.TryParse(Console.ReadLine(), out int firstCarSelect);
        if (!validation || firstCarSelect == 0) { Console.WriteLine("Invalid input try again "); continue; }


        Console.WriteLine("Select the second car");
        for (int i = 0; i < carArray.Length; i++)
        {
            Console.WriteLine($"{i+1}. {carArray[i].Model}");
        }
        validation = int.TryParse(Console.ReadLine(), out int secondCarSelect);
        if (!validation || firstCarSelect == 0) { Console.WriteLine("Invalid input try again "); continue; }
        else if (firstCarSelect == secondCarSelect) { Console.WriteLine("Cannot be the same as the previous car, try agian"); continue; }


        Console.WriteLine("Select a driver for the first car");
        for (int i = 0; i < driverArray.Length; i++)
        {
            Console.WriteLine($"{i+1}. {driverArray[i].Name}");
        }
        validation = int.TryParse(Console.ReadLine(), out int firstCarDriverSelect);
        if (!validation || firstCarSelect == 0) { Console.WriteLine("Invalid input try again "); continue; }




        Console.WriteLine("Select a driver for the second car");
        for (int i = 0; i < driverArray.Length; i++)
        {
            Console.WriteLine($"{i+1}. {driverArray[i].Name}");
        }
        validation = int.TryParse(Console.ReadLine(), out int secondCarDriverSelect);
        if (!validation || firstCarSelect == 0) { Console.WriteLine("Invalid input try again "); continue; }
        else if (secondCarSelect == firstCarSelect) { Console.WriteLine("Cannot be the same as the previous driver try agian"); continue; }


        Car firstCar = carArray[firstCarSelect - 1];
        Car secondCar = carArray[secondCarSelect - 1];
        firstCar.Driver = driverArray[firstCarDriverSelect - 1];
        secondCar.Driver = driverArray[secondCarDriverSelect - 1];

        if(firstCar.CalculateSpeed() > secondCar.CalculateSpeed())
        {
            Console.WriteLine($"The winner is {firstCar.Driver.Name} with the {firstCar.Model}. \n (SCORE: {firstCar.CalculateSpeed()} SPEED: {firstCar.Speed})");
        }
        else if (secondCar.CalculateSpeed() > firstCar.CalculateSpeed())
        {
            Console.WriteLine($"The winner is {secondCar.Driver.Name} with the {secondCar.Model}.\n (SCORE: {secondCar.CalculateSpeed()}) SPEED: {secondCar.Speed}) ");
        }
        else
        {
            Console.WriteLine($"BOTH FINISHED AT THE SAME TIME UNBELIEVABLE  \n FIRST CAR SCORE: {firstCar.CalculateSpeed()} \n SECOND CAR SCORE: {secondCar.CalculateSpeed()} ");
        }

        while (true)
        {
            Console.WriteLine("Race again? (Y/N)");
             response = Console.ReadLine();
            if (response.ToUpper() != "Y" && response.ToUpper() != "N") { Console.WriteLine("Invalid input, Try again"); continue; }
            else break;
        }
        if(response.ToUpper() == "Y")
        {
            continue;
        }
        else
        {
            break;
        }

    }
}


RaceCars();