using NUnit.Framework;
using System.Net.Mail;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string testEmail = "test@example.com";

        // Act
        bool actualResult = Email.IsValidEmail(testEmail);

        // Assert
        Assert.IsTrue(actualResult);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string testEmail = "0";

        // Act
        bool actualResult = Email.IsValidEmail(testEmail);

        // Assert
        Assert.IsFalse(actualResult);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string testEmail = "";

        // Act
        bool actualResult = Email.IsValidEmail(testEmail);

        // Assert
        Assert.IsFalse(actualResult);
    }
}
