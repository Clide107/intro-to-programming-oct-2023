
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("118", 118)]
    public void SingleDigit(string input, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(input);
        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData("1,1", 2)]
    [InlineData("2,2", 4)]
    public void DoubleDigit(string input, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,1,3,5", 10)]
    [InlineData("2,6,7", 15)]
    public void UnknownNumbers(string input, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n1", 2)]
    [InlineData("2\n2", 4)]
    [InlineData("2\n2,3", 7)]
    public void NewLines(string input, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(input);
        Assert.Equal(expected, result);
    }
}
