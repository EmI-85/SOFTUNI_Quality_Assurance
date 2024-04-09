using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class RepeatStringsTests
{
    [Test]
    public void Test_Repeat_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Repeat_SingleInputString_ReturnsRepeatedString()
    {
        string[] input = new string[] { "emi" };

        string actualResult = RepeatStrings.Repeat(input);
        string expectedResult = "emiemiemi";

        Assert.That (actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Repeat_MultipleInputStrings_ReturnsConcatenatedRepeatedStrings()
    {
        string[] input = new string[] { "3412", "AbA" };

        string actualResult = RepeatStrings.Repeat(input);
        string expectedResult = "3412341234123412AbAAbAAbA";

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
