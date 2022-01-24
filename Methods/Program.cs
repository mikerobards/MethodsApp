using Methods;

//using static Methods.SampleMethods;
//SayHi();


//for (int i = 0; i < 10; i++)
//{
//    SampleMethods.SayHi();
//}

// DRY - Don't repeat yourself
// SOLID - SRP - Single Responsiblity Principle

string name = ConsoleMessages.GetUsersName();

ConsoleMessages.SayHi(name);

// double result = MathShortcuts.Add(5, 3);
Console.WriteLine($"the result is {MathShortcuts.Add(5, 3)}");

double[] vals = new double[] { 2,5,6,21,52,98 };
MathShortcuts.AddAll(vals);

ConsoleMessages.SayGoodbye();





