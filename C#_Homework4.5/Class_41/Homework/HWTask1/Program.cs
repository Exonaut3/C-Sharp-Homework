using Qinshift.Class07.Domain;


Manager elonMuskrat = new Manager("Elon", "Mustkrat", 10000000);
Manager elonichMuskratovich = new Manager("Elonich", "Mustkratatovich", 9000000000000000);


Contractor japaneseSalaryMan1 = new Contractor()
{
    FirstName = "Wagie",
    LastName = "Sama",
    WorkHours = 8,
    PayPerHour = 15,
    Responsible = elonMuskrat
};
Contractor japaneseSalaryMan2 = new Contractor()
{
    FirstName = "Suzuki",
    LastName = "Honda",
    WorkHours = 25,
    PayPerHour = 10,
    Responsible = elonichMuskratovich
};

SalesPerson doorToDoor = new SalesPerson("Bryan", "Griffin (From family guy)");

//Manager[] managerArray = {elonichMuskratovich, elonMuskrat};
//Contractor[] contractorArray = {japaneseSalaryMan1, japaneseSalaryMan2};
//SalesPerson[] salesPersonArray = { doorToDoor };

Employee[] Company =
{
  elonMuskrat,
  elonichMuskratovich,
  japaneseSalaryMan1,
  japaneseSalaryMan2,
  doorToDoor
};


CEO kaibaCorporation = new CEO()
{
    FirstName = "Seto",
    LastName = "Kaiba",
    Employees = Company,
    Shares = 9001,
    
};

kaibaCorporation.PrintInfo();
kaibaCorporation.PrintEmployees();
Console.WriteLine(kaibaCorporation.GetSalary());
