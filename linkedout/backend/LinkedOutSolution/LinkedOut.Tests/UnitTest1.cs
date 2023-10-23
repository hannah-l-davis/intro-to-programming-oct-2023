namespace LinkedOut.Tests;

public class UnitTest1
{
    [Fact] // Attribute like @Fact
    public void CanAddTwoIntegers()
    {
        // Given - "arrange" - setupo the world
        int a = 10;
        int b = 20;
        int total;

        //when - "act" - poke at it and see what happens
        total = a + b; // "System under Test" ("SUT")

        // Then - "Assert" - Find out.
        Assert.Equal(30, total);
    }

    [Theory]
    [InlineData(10, 20, 30)]
    [InlineData(2, 2, 4)]
    [InlineData(10, 2, 12)]


    public void CanAddAnyTwoIntegers(int a, int b, int expected)
    {

        int total = a + b;

        Assert.Equal(expected, total);
    }
    [Fact]
    public void CanFormatNames()
    {
        NameFormatter formatter = new NameFormatter();

        string fullName = formatter.FormatName("Han", "Solo");

        Assert.Equal("Solo, Han", fullName);
    }
}