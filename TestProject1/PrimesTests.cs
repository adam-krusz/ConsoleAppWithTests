using Xunit;

public class PrimesTests
{
    [Fact]
    public void IsPrime_ReturnsFalse_ForLessThanTwo()
    {
        // Act
        var result = Primes.IsPrime(1);

        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    public void IsPrime_ReturnsTrue_ForPrimeNumbers(int number)
    {
        // Act
        var result = Primes.IsPrime(number);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(9)]
    public void IsPrime_ReturnsFalse_ForNonPrimeNumbers(int number)
    {
        // Act
        var result = Primes.IsPrime(number);

        // Assert
        Assert.False(result);
    }
}