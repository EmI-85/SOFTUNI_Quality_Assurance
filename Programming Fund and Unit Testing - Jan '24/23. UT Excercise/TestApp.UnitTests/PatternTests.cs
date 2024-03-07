using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        int[] inputArray = { 1, 2, 1, 3, 4, 10, 12, 15 };

        int[] actualResult = Pattern.SortInPattern(inputArray);
        int[] expectedResult = new[] { 1, 15, 2, 12, 3, 10, 4 };

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        int[] inputArray = Array.Empty<int>();
        int[] actualResult = Pattern.SortInPattern(inputArray);

        Assert.That(actualResult, Is.Empty);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        int[] inputArray = { 4 };

        int[] actualResult = Pattern.SortInPattern(inputArray);
        int[] expectedResult = new[] { 4 };

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
