using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedwords = new string[] { };
        string text = "Lorem ipsum etc.";
        string expectedResult = "Lorem ipsum etc.";

        // Act
        string actualResult = TextFilter.Filter(bannedwords, text);
        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        string[] bannedwords = new string[] { "name" };
        string text = "Hello, my name is Emi";
        string expectedResult = "Hello, my **** is Emi";

        // Act
        string actualResult = TextFilter.Filter(bannedwords, text);
        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        string[] bannedwords = new string[] { };
        string text = "Hello, my name is Emi";
        string expectedResult = "Hello, my name is Emi";

        // Act
        string actualResult = TextFilter.Filter(bannedwords, text);
        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        string[] bannedwords = new string[] { "live", "but", "from Varna" };
        string text = "Hello, I'm Emi and I live in Sofia, but I am from Varna";
        string expectedResult = "Hello, I'm Emi and I **** in Sofia, *** I am **********";

        // Act
        string actualResult = TextFilter.Filter(bannedwords, text);
        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
