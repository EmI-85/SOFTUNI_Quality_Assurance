using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        //Arrange
        string input = string.Empty;
        int pos = 3;
        string expected = string.Empty;
        //Act
        string result = StringRotator.RotateRight(input, pos);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        //Arrange
        string input = "abcdef";
        int pos = 0;
        string expected = "abcdef";
        //Act
        string result = StringRotator.RotateRight(input, pos);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        //Arrange
        string input = "abcdef";
        int pos = 2;
        string expected = "efabcd";
        //Act
        string result = StringRotator.RotateRight(input, pos);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        //Arrange
        string input = "abcdef";
        int pos = -1;
        string expected = "fabcde";
        //Act
        string result = StringRotator.RotateRight(input, pos);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        //Arrange
        string input = "abcdef";
        int pos = 10;
        string expected = "cdefab";
        //Act
        string result = StringRotator.RotateRight(input, pos);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
