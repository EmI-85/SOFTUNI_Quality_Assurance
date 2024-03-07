using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        int n = 0;
        int expectedResult = 0;

        int actualResult = Fibonacci.CalculateFibonacci(n);

        Assert.AreEqual(expectedResult, actualResult);

    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        int n = 9;
        int expectedResult = 34;

        int actualResult = Fibonacci.CalculateFibonacci(n);

        Assert.AreEqual(expectedResult, actualResult);

    }
}