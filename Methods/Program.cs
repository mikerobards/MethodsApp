using Methods;

//using static Methods.SampleMethods;
//SayHi();


//for (int i = 0; i < 10; i++)
//{
//    SampleMethods.SayHi();
//}

// DRY - Don't repeat yourself
// SOLID - SRP - Single Responsiblity Principle

//string name = ConsoleMessages.GetUsersName();

//ConsoleMessages.SayHi(name);

//// double result = MathShortcuts.Add(5, 3);
//Console.WriteLine($"the result is {MathShortcuts.Add(5, 3)}");

//double[] vals = new double[] { 2,5,6,21,52,98 };
//MathShortcuts.AddAll(vals);

//ConsoleMessages.SayGoodbye();

(string firstName, string lastName) = ConsoleMessages.GetFullName();
// var fullName = ConsoleMessages.GetFullName();
// var (firstName, lastName) = ConsoleMessages.GetFullName();

// Discard character (_)
// (string firstName, _) = ConsoleMessages.GetFullName();



Console.WriteLine($"First Name: {firstName}");
// Console.WriteLine($"Last Name: {lastName}");

//string ageText = "43";
//bool isValidAge = int.TryParse(ageText, out int age);










