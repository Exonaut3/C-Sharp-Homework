using ClassLibrary1.Classes;

Teacher goodCop = new(1, "Bob Bobski (our beloved)", "bobmeister123", new List<string> {"PE", "IT", "Art Class", "Math", "English"});
Teacher badCop = new(2, "Rob Robski (our behated)", "XXX_TheRobber_XXX", new List<string> { "History", "Biology", "Physics" });

Student adhdDetence = new(1, "Dimeon Svojakov", "RFDSpades", new Dictionary<string, int> { { "IT", 5 }, { "Math", 4 }, { "English", 5 }, { "PE", 5 }, { "History", 2 } });
Student theKolega = new(2, "Garko Mulevski", "PsyMaki", new Dictionary<string, int> { { "PE", 3}, { "Biology", 4}, { "Physics", 5}, { "Art Class", 5} });


goodCop.PrintUser();
badCop.PrintUser();

adhdDetence.PrintUser();
theKolega.PrintUser();

//The rest of the methods
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("===THE REST OF THE METHODS===");

goodCop.PrintSubjects();
badCop.PrintSubjects();

adhdDetence.PrintGrades();
theKolega.PrintGrades();
Console.ResetColor();