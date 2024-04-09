using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string emptyString = string.Empty;
        // Act
        string actualResult = StringReverse.Reverse(emptyString);

        // Assert
        Assert.AreEqual(string.Empty, actualResult);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        string letter = "s";

        string actualResult = StringReverse.Reverse(letter);
        string expectedResult = "s";

        Assert.AreEqual(expectedResult, actualResult, "Reversal did not work properly.");
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        string text = "stosho";

        string expectedResult = "ohsots";
        string actualResult = StringReverse.Reverse(text);

        Assert.AreEqual(expectedResult, actualResult, "String is NOT reversed properly!");
    }
}
