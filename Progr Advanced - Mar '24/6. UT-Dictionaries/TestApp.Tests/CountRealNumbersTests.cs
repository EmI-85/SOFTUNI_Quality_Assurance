using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] input = new int[0];
        // Act
        string result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 96 };
        // Act
        string result = CountRealNumbers.Count(input);
        string expectedResult = "96 -> 1";

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        int[] input = new int[] { 96, 1996, 10, 1996 };
      
        string result = CountRealNumbers.Count(input);

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("10 -> 1");
        sb.AppendLine("96 -> 1");
        sb.AppendLine("1996 -> 2");
        
        string expectedResult = sb.ToString().TrimEnd();

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        int[] input = new int[] { -10, -1010, -15, -1, -13, -10 };

        string result = CountRealNumbers.Count(input);

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("-1010 -> 1");
        sb.AppendLine("-15 -> 1");
        sb.AppendLine("-13 -> 1");
        sb.AppendLine("-10 -> 2");
        sb.AppendLine("-1 -> 1");

        string expectedResult = sb.ToString().TrimEnd();

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        int[] input = new int[] { 0, -10, -15, 10, 15, 0, -15 };

        string result = CountRealNumbers.Count(input);

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("-15 -> 2");
        sb.AppendLine("-10 -> 1");
        sb.AppendLine("0 -> 2");
        sb.AppendLine("10 -> 1");
        sb.AppendLine("15 -> 1");

        string expectedResult = sb.ToString().TrimEnd();

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
