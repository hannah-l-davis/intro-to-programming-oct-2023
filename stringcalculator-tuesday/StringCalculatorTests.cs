
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
        var calculatior = new StringCalculator();
        var result = calculatior.Add(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,1", 2)]
    [InlineData("1,9", 10)]
    public void TwoDigits(string input, int expected)
    {
        var calculatior = new StringCalculator();
        var result = calculatior.Add(input);
        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData("1,1,1", 3)]
    [InlineData("1,9,10", 20)]
    public void AnyDigits(string input, int expected)
    {
        var calculatior = new StringCalculator();
        var result = calculatior.Add(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n2, 3", 6)]
    [InlineData("1,9\n10", 20)]
    public void NewLineSeparator(string input, int expected)
    {
        var calculatior = new StringCalculator();
        var result = calculatior.Add(input);
        Assert.Equal(expected, result);
    }
}