namespace CSL.FizzBuzz.ConsoleApp;

public class FizzBuzzEngine
{
    private const string Fizz = "Fizz";
    private const string Buzz = "Buzz";

    public IList<string> GetResults(int start, int end)
    {
        if(start > end)
        {
            throw new ArgumentException("Start must be less than or equal to end");
        }

        var lengthOfRange = end - start + 1;
        var results = Enumerable.Range(start, lengthOfRange).Select(GetResult);

        return results.ToList();
    }
    
    public string GetResult(int input)
    {
        var isFizz = IsFizz(input);
        var isBuzz = IsBuzz(input);
        
        if(isFizz && isBuzz)
        {
            return $"{Fizz}{Buzz}";
        }
        
        if(isFizz)
        {
            return Fizz;
        }
        
        if(isBuzz)
        {
            return Buzz;
        }

        return $"{input}";
    }
    
    private static bool IsFizz(int input)
    {
        return input % 3 == 0;
    }
    
    private static bool IsBuzz(int input)
    {
        return input % 5 == 0;
    }
}