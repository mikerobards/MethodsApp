using Methods;

//using static Methods.SampleMethods;
//SayHi();


//for (int i = 0; i < 10; i++)
//{
//    SampleMethods.SayHi();
//}

// DRY - Don't repeat yourself
// SOLID - SRP - Single Responsiblity Principle

Console.Write("What is your name: ");

string name = Console.ReadLine();

ConsoleMessages.SayHi(name);

MathShortcuts.Add(5, 3);

ConsoleMessages.SayGoodbye();





