using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringModifierTests
{
    [Test]
    public void Test_Modify_EmptyString_ReturnsEmptyString()
    {
        //Arrange
        string input = string.Empty;
        string expectedResult = string.Empty;
        //Act
        string actualResult = StringModifier.Modify(input);
        //Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Modify_SingleWordWithEvenLength_ReturnsUppperCaseWord()
    {
        //Arrange
        string input = "string";
        string expectedResult = "STRING";
        //Act
        string actualResult = StringModifier.Modify(input);
        //Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Modify_SingleWordWithOddLength_ReturnsToLowerCaseWord()
    {
        //Arrange
        string input = "odd";
        string expectedResult = "odd";
        //Act
        string actualResult = StringModifier.Modify(input);
        //Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Modify_MultipleWords_ReturnsModifiedString()
    {
        //Arrange
        string input = "odd string";
        string expectedResult = "odd STRING";
        //Act
        string actualResult = StringModifier.Modify(input);
        //Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}

