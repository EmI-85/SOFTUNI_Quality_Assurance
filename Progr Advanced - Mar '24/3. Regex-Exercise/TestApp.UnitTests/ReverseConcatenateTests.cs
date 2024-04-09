using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    // TODO: finish the test
    [TestCase (new string[] { },"")]
    [TestCase (new string[] { "" },"")]
    [TestCase (new string[] { " " }," ")]
    [TestCase (new string[] { "emi" },"emi")]
    [TestCase (new string[] { "Plovdiv", "Sofia", "Pernik"},"PernikSofiaPlovdiv")]
    [TestCase(new string[] { null }, "")]
    [TestCase(null, "")]
    [TestCase(new string[] { "Black Sea", "resort" }, "resortBlack Sea")]
    [TestCase(new string[] { "Ivan Shopov", "Ilko Kirilov", "Some More Words", "To be Added" }, "To be AddedSome More WordsIlko KirilovIvan Shopov")]

    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString(string[] input, string expected)
    {
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
