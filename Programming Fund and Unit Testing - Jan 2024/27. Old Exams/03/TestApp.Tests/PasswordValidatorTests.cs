using NUnit.Framework;

namespace TestApp.Tests;

public class PasswordValidatorTests
{
    [Test]
    public void Test_CheckPassword_ValidPassword_ReturnsValidMessage()
    {
        string input = "Pass123";

        string actual = PasswordValidator.CheckPassword(input);
        string expected = "Password is valid";

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckPassword_PasswordTooShort_ReturnsErrorMessage()
    {
        string input = "Short";

        string actual = PasswordValidator.CheckPassword(input);
        string expected = "Password must be between 6 and 10 characters";

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckPassword_ContainsSpecialCharacters_ReturnsErrorMessage()
    {
        string input = "Inv@Pass";

        string actual = PasswordValidator.CheckPassword(input);
        string expected = "Password must consist only of letters and digits";

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckPassword_InsufficientDigits_ReturnsErrorMessage()
    {
        string input = "NoDigits";

        string actual = PasswordValidator.CheckPassword(input);
        string expected = "Password must have at least 2 digits";

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckPassword_ValidPasswordWithMaximumLength_ReturnsValidMessage()
    {
        string input = "ValPass123";

        string actual = PasswordValidator.CheckPassword(input);
        string expected = "Password is valid";

        Assert.That(actual, Is.EqualTo(expected));
    }
}
