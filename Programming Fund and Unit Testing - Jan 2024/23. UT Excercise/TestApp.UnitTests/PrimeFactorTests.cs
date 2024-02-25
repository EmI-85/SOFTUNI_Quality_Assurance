using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        long primeNum = 7;
        long expected = 7;

        long actual = PrimeFactor.FindLargestPrimeFactor(primeNum);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        long primeNum = 100;
        long expected = 5;

        long actual = PrimeFactor.FindLargestPrimeFactor(primeNum);

        Assert.AreEqual(expected, actual);
    }
}
