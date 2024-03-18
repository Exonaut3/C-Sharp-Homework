string date = "dddd, dd MMMM yyyy";
DateTime dataNew = new DateTime(2024, 12, 12, 2,3,4);

string result = dataNew.ToString(date);
Console.WriteLine(result);