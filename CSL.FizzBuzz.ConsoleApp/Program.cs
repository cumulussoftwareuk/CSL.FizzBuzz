using CSL.FizzBuzz.ConsoleApp;

Console.WriteLine("FizzBuzz from 1 to 100");

const int min = 1;
const int max = 100;

var engine = new FizzBuzzEngine();
var results = engine.GetResults(min, max);

foreach(var result in results)
{
    Console.WriteLine(result);
}

Console.WriteLine("Press any key to exit...");