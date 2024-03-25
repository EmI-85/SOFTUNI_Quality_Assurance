using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        string[] input = new string[0] { };

        string result = OddOccurrences.FindOdd(input);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        string[] input = new string[] { "sto", "sto", "shop", "shop", "shop", "shop" };

        string result = OddOccurrences.FindOdd(input);
        string expected = "";

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        string[] input = new string[] { "sofia", "plovdiv", "sofia" };

        string result = OddOccurrences.FindOdd(input);
        string expected = "plovdiv";

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        string[] input = new string[] { "varna", "sofia", "plovdiv", "varna", "sofia", "sofia" };

        string result = OddOccurrences.FindOdd(input);
        string expected = "sofia plovdiv";

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        string[] input = new string[] { "varnA", "Sofia", "PloVdiv", "VarnA", "SOFia", "sofiA" };

        string result = OddOccurrences.FindOdd(input);
        string expected = "sofia plovdiv";

        Assert.That(result, Is.EqualTo(expected));
    }
}
