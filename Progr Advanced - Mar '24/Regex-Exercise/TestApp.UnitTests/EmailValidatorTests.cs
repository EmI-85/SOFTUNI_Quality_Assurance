using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    [TestCase("stoyanshopov032@gmail.com")]
    [TestCase("stoyan.shopov@gmail.com")]
    [TestCase("stoyan_shopov@gmail.com")]
    [TestCase("stoyan%shopov@gmail.com")]
    [TestCase("stoyan-shopov@gmail.com")]
    [TestCase("stoyan-shopov@gmail.com")]
    [TestCase("stoyan+shopov@gmail-123.com")]
    [TestCase("stoyan-shopov@gmail.123.com")]

    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    [TestCase("")]
    [TestCase("stoyanshopov032@gmailcom")]
    [TestCase("stoyan.shopovgmail.com")]
    [TestCase("stoyan_shopov@@gmail.com")]
    [TestCase("@gmail.com")]
    [TestCase("gmail.com")]
    [TestCase("stoyan-shopovgmailcom")]
    [TestCase("1")]
    [TestCase("stoyan-shopov@gmail.c")]

    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
