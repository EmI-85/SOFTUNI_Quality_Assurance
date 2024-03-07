using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        int[] nullArray = null;

        Assert.That(() => LongestIncreasingSubsequence.GetLis(nullArray), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        int[] emptyArray = new int[0];
        string actual = LongestIncreasingSubsequence.GetLis(emptyArray);

        string expected = string.Empty;

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        int[] inputArray = new int[] { 1 };

        string actual = LongestIncreasingSubsequence.GetLis(inputArray);
        string expected = "1";

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        int[] inputArray = new int[] { 100, 3, 5, 6, 9, 2, 11, 10 };

        string actual = LongestIncreasingSubsequence.GetLis(inputArray);
        string expected = "3 5 6 9 11";

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        int[] inputArray = new int[] { 1, 3, 5, 6, 9, 2, 11, 10 };

        string actual = LongestIncreasingSubsequence.GetLis(inputArray);
        string expected = "1 3 5 6 9 11";

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetLis_SortedArrayNeg_ReturnsLongestIncreasing()
    {
        int[] inputArray = new int[] { -1, 3, 5, -6, 9, 2, 11, 10 };

        string actual = LongestIncreasingSubsequence.GetLis(inputArray);
        string expected = "-1 3 5 9 11";

        Assert.That(actual, Is.EqualTo(expected));
    }
}
