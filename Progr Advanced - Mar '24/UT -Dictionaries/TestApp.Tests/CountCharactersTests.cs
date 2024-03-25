using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [TestCase]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        List<string> input = new() { "" };

        string result = CountCharacters.Count(input);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        List<string> input = new() { "a" };

        string result = CountCharacters.Count(input);
        string expectedResult = "a -> 1";

        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        List<string> input = new() { "a", "bc", "bca" };

        string result = CountCharacters.Count(input);
        
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("a -> 2");
        sb.AppendLine("b -> 2");
        sb.Append("c -> 2");

        string expectedResult = sb.ToString();

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        List<string> input = new() { "a%", "b%c", "bca", "%" };

        string result = CountCharacters.Count(input);

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("a -> 2");
        sb.AppendLine("% -> 3");
        sb.AppendLine("b -> 2");
        sb.Append("c -> 2");
       

        string expectedResult = sb.ToString();

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
