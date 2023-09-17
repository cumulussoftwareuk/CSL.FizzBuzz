using CSL.FizzBuzz.ConsoleApp;

namespace CSL.FizzBuzz.UnitTests;

public class FizzBuzzEngineTests
{
    [Fact]
    public void NegativeRangeThrowsArgumentException()
    {
        var calculator = new FizzBuzzEngine();

        Action action = () => calculator.GetResults(1, 0);
        
        action.Should().Throw<ArgumentException>();
    }

    [Theory]
    [InlineData(1, 1, "1")]
    [InlineData(2, 3, "2", "Fizz")]
    [InlineData(3,5, "Fizz", "4", "Buzz")]
    [InlineData(14, 18, "14", "FizzBuzz", "16", "17", "Fizz")]
    public void ValidRangeReturnsResults(int start, int end, params string[] expected)
    {
        var calculator = new FizzBuzzEngine();

        var results = calculator.GetResults(start, end);
        
        results.Should().Equal(expected);
    }

    [Theory]
    [InlineData(-3)]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    [InlineData(12)]
    [InlineData(18)]
    [InlineData(99)]
    public void MultiplesOfThreeReturnFizz(int input)
    {
        var calculator = new FizzBuzzEngine();
        
        var result = calculator.GetResult(input);
        
        result.Should().Be("Fizz");
    }
    
    [Theory]
    [InlineData(-5)]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    [InlineData(25)]
    [InlineData(100)]
    public void MultiplesOfFiveReturnBuzz(int input)
    {
        var calculator = new FizzBuzzEngine();
        
        var result = calculator.GetResult(input);
        
        result.Should().Be("Buzz");
    }

    [Theory]
    [InlineData(-15)]
    [InlineData(0)]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(45)]
    public void MultiplesOfThreeAndFiveReturnFizzBuzz(int input)
    {
        var calculator = new FizzBuzzEngine();
        
        var result = calculator.GetResult(input);
        
        result.Should().Be("FizzBuzz");
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(7)]
    [InlineData(8)]
    [InlineData(98)]
    public void MultiplesOfNeitherThreeNorFiveReturnTheInput(int input)
    {
        var calculator = new FizzBuzzEngine();
        
        var result = calculator.GetResult(input);
        
        result.Should().Be(input.ToString());
    }
}