using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    // TODO: finish the test
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";

        // Act
        string actualResult = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        string expectedResult = "The quick brown jumps over the lazy dog";
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        string toRemove = "Hello";
        string input = "Hello, my name is Emiliya!";

        // Act
        string actualResult = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        string expectedResult = ", my name is Emiliya!";
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        string toRemove = "Golf 3";
        string input = "The best car in the world is Golf 3";

        // Act
        string actualResult = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        string expectedResult = "The best car in the world is";
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        string toRemove = "Golf";
        string input = "First Golf was made in 1976, and the latest version of Golf Golf 8 id from 2024. The best car in the world is not Golf";

        // Act
        string actualResult = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        string expectedResult = "First was made in 1976, and the latest version of 8 id from 2024. The best car in the world is not";
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
