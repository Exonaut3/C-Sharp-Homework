using The.Domain;


CarsData.LoadCars();
List<Car> cars = CarsData.Cars;

//1
List<Car> euOrigin = cars.Where(x => x.Origin.ToLower() == "europe").ToList();
//2
List<int> uniqueCylinders = cars.Select(x => x.Cylinders).Distinct().ToList();
//3
List<string> carNameToUpper = cars.Select(x=> x.Model.ToUpper()).ToList();
//4
bool anyWithMoreThan300HP = cars.Where(x => x.HorsePower > 300).Any();
//5
Car carWithTheMostHP = cars.MaxBy(x=> x.HorsePower);
//6
List<Car> chevroletDescending = cars.Where(x=> x.Model.Contains("Chevrolet")).OrderByDescending(x => x.Weight).ToList();
//7
Car carWithTheLongestName = cars.MaxBy(x => x.Model.Count());
//8
List<Car> groupByOrigin = cars.OrderBy(x => x.Origin.Min()).ToList();    //se mlatev mnogu na ova ali nekako ispadna tochno, nz dali e na srekja
//9
List<Car> the5CarsWithHighestHP = cars.OrderByDescending(x => x.HorsePower).Take(5).ToList();
//10
Car carWithhighestAccelerationTime = cars.MaxBy(x => x.AccelerationTime);
//11
List<string> modelAndHorsepowerGreaterThan200 = cars.Where(x => x.HorsePower > 200).Select(x => $"{x.Model} {x.HorsePower}").ToList();
//            ^^^^^^^^^^^^^^^^^^^^^^^^^  ne mi davashe da ja resham so noviot nachin sto mi beshe pokazan vo fidbekot :((((
// odnosno new Car(x.Model x.HorsePower) 
//12
List<string> uniqueOriginsOrderedAlphabetically = cars.Select(x=> x.Origin).Distinct().OrderBy(x=> x).ToList();
//13
List<Car> carsWith4CylindersOrderedTwice = cars.Where(x => x.Cylinders == 4).OrderBy(x => x.Origin).OrderBy(x => x.HorsePower).ToList();
//14
List<Car> cylendersAbove6 = cars.Where(x => x.Cylinders > 6).ToList();
List<Car> exactly4CylindersAndPlus100HP = cars.Where(x => x.Cylinders == 4 && x.HorsePower > 110.0).ToList();
List<Car> weirdCarJoin = new List<Car>();
foreach(Car car in cylendersAbove6)
{
    weirdCarJoin.Add(car);
}
foreach(Car car in exactly4CylindersAndPlus100HP)
{
    weirdCarJoin.Add(car);
}
//malce somnitelno ali mislam vaka treba
//15
List<Car> over200HorsePower = cars.Where(x => x.HorsePower > 200).ToList();
Car carWith200HPMaxPerGalon = over200HorsePower.MaxBy(x => x.MilesPerGalon);
Car carWith200HPMMinPerGalon = over200HorsePower.MinBy(x => x.MilesPerGalon);
double averageMilesPerGalon = over200HorsePower.Select(x=>x.MilesPerGalon).Average();
//16
List<string> greatNipponLmao = cars.Where(x => x.Origin == "Japan").Select(x => x.Origin).OrderBy(x => x).ToList();
//17
List<string> carsWithNumbersinnem = cars.Where(x => x.Model.Contains("1") || x.Model.Contains("2") || x.Model.Contains("3") || x.Model.Contains("4") || x.Model.Contains("5") || x.Model.Contains("6") || x.Model.Contains("7") || x.Model.Contains("8") || x.Model.Contains("9") || x.Model.Contains("0")).Select(x=>x.Model).OrderBy(x => x.Contains("9")).OrderBy(x => x.Contains("8")).OrderBy(x => x.Contains("7")).OrderBy(x => x.Contains("6")).OrderBy(x => x.Contains("5")).OrderBy(x => x.Contains("4")).OrderBy(x => x.Contains("3")).OrderBy(x => x.Contains("3")).OrderBy(x => x.Contains("2")).OrderBy(x => x.Contains("1")).OrderBy(x => x.Contains("0")).Reverse().ToList();

//Console.WriteLine($"{carWithhighestAccelerationTime.Model} {carWithhighestAccelerationTime.AccelerationTime} " );




////1
//Helper<Car>.WriteInColor("===================== ALL CARS WITH EU ORIGIN ===========================");
//Helper<Car>.CarReader(euOrigin);
////2
//Helper<Car>.WriteInColor("===================== UNIQUE CYLINDER VALUES ===========================");
//RegularHelper<int>.RegularReader(uniqueCylinders);
////3
//Helper<Car>.WriteInColor("===================== ALL CAR MODELS TO UPPER ===========================");
//RegularHelper<string>.RegularReader(carNameToUpper);
////4
//Helper<Car>.WriteInColor("===================== IS THERE A CAR WITH MORE THAN 300HP? ===========================");
//Console.WriteLine(anyWithMoreThan300HP);
////5
//Helper<Car>.WriteInColor("===================== CAR WITH THE HIGHEST HORSEPOWER ===========================");
//Console.WriteLine(carWithTheMostHP);
////6
//Helper<Car>.WriteInColor("===================== ALL CHEVROLET CARS ORDERED BY WEIGHT IN DESCENDING ORDER ===========================");
//Helper<Car>.CarReader(chevroletDescending);
////7
//Helper<Car>.WriteInColor("===================== CAR WITH THE LONGEST NAME ===========================");
//Console.WriteLine(carWithTheLongestName);
////8
//Helper<Car>.WriteInColor("===================== GROUP BY ORIGIN ===========================");
//Helper<Car>.CarReader(groupByOrigin);
////9
//Helper<Car>.WriteInColor("===================== THE 5 CARS WITH THE HIGHEST HP ===========================");
//Helper<Car>.CarReader(the5CarsWithHighestHP);
////10
//Helper<Car>.WriteInColor("===================== CAR WITH THE HIGHEST ACCELERATION TIME ===========================");
//Console.WriteLine(carWithhighestAccelerationTime);
////11
//Helper<Car>.WriteInColor("===================== MODEL AND HORSEPOWER GREATER THAN 200 ===========================");
//RegularHelper<string>.RegularReader(modelAndHorsepowerGreaterThan200);
////12
//Helper<Car>.WriteInColor("===================== UNIQUE ORIGINS SORTED ALPHABETICALLY ===========================");
//RegularHelper<string>.RegularReader(uniqueOriginsOrderedAlphabetically);
////13
//Helper<Car>.WriteInColor("===================== ALL CARS WITH 4 CYLINDERS ORDERED BY ORIGIN AND THEN HORSEPOWER ===========================");
//Helper<Car>.CarReader(carsWith4CylindersOrderedTwice);
////14
//Helper<Car>.WriteInColor("===================== 4 AND 6 CYLINDERS JOINED ===========================");
//Helper<Car>.CarReader(weirdCarJoin);
////15
//Helper<Car>.WriteInColor("===================== CARS ABOVE 200HP AND THEIR MAXIMUM, MINIMUM AND AVERAGE MILES PER GALON ===========================");
//Console.WriteLine(carWith200HPMaxPerGalon);
//Console.WriteLine(carWith200HPMMinPerGalon);
//Console.WriteLine(averageMilesPerGalon);
////16
//Helper<Car>.WriteInColor("===================== GREAT NIPPON LMAO ===========================");
//RegularHelper<string>.RegularReader(modelAndHorsepowerGreaterThan200);
////17
//Helper<Car>.WriteInColor("===================== ALL THE CAR MODELS SORTED BY WHICH NUMBER THEY CONTAIN IN THEIR NAME STARTING WITH 0 ===========================");
//Helper<Car>.WriteInColor("===================== CHECK OUT THE SORTING PROCESS IT'S HIDEOUS ===========================");
//RegularHelper<string>.RegularReader(carsWithNumbersinnem);



//foreach (var type in carsWithNumbersinnem)
//{
//    Console.WriteLine(type);
//    //type.PrintInfo();
//}