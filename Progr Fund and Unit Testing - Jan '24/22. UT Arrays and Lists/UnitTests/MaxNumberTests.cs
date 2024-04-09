using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        List<int> input = new List<int>() { 100 };

        int result = MaxNumber.FindMax(input);
        int expected = 100;

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        List<int> input = new List<int>() { 100, 200, 1000, 5, 28 };

        int result = MaxNumber.FindMax(input);
        int expected = 1000;

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        List<int> input = new List<int>() { -3, -200, -1520, -5, -69 };

        int result = MaxNumber.FindMax(input);
        int expected = -3;

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        List<int> input = new List<int>() { 203, -291, -1520, 0, -5, 369 };

        int result = MaxNumber.FindMax(input);
        int expected = 369;

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        List<int> input = new List<int>() { 203, 369, -291, -1520, 0, -5, 369 };

        int result = MaxNumber.FindMax(input);
        int expected = 369;

        Assert.That(expected, Is.EqualTo(result));
    }
}
