using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        char firstChar = 'a';
        char secondChar = 'b';

        string actualResult = CharacterRange.GetRange(firstChar, secondChar);
        string expectedResult = string.Empty;

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        char firstChar = 'b';
        char secondChar = 'a';

        string actualResult = CharacterRange.GetRange(firstChar, secondChar);
        string expectedResult = string.Empty;

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        char firstChar = 'a';
        char secondChar = 'c';

        string actualResult = CharacterRange.GetRange(firstChar, secondChar);
        string expectedResult = 'b'.ToString();

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        char firstChar = 'd';
        char secondChar = 'g';

        string actualResult = CharacterRange.GetRange(firstChar, secondChar);
        string expectedResult = "e f";

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        char firstChar = 'x';
        char secondChar = 'z';

        string actualResult = CharacterRange.GetRange(firstChar, secondChar);
        string expectedResult = 'y'.ToString();

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
