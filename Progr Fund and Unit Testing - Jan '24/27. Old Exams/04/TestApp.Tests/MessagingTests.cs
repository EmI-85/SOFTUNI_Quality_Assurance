using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.Tests;

public class MessagingTests
{
    [Test]
    public void Test_GetMessage_WithValidInput_ReturnsExpectedMessage()
    {
        List<int> input = new List<int> { 112, 800, 26, 55 };
        string text = "softuni";

        string actualResult = Messaging.GetMessage(input, text);

        string expectedResult = "ufnt";
        
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GetMessage_EmptyList_ReturnsEmptyString()
    {
        List<int> input = new List<int> { };
        string text = "softuni";

        string actualResult = Messaging.GetMessage(input, text);

        string expectedResult = string.Empty;

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GetMessage_EmptyString_ReturnsEmptyString()
    {
        List<int> input = new List<int> { 112, 800, 26, 55 };
        string text = string.Empty;

        string actualResult = Messaging.GetMessage(input, text);

        string expectedResult = string.Empty;

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GetMessage_NullList_ReturnsEmptyString()
    {
        List<int> input = null;
        string text = string.Empty;

        string actualResult = Messaging.GetMessage(input, text);

        string expectedResult = string.Empty;

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GetMessage_NullString_ReturnsEmptyString()
    {
        List<int> input = new List<int> { 112, 800, 26, 55 };
        string text = null;

        string actualResult = Messaging.GetMessage(input, text);

        string expectedResult = string.Empty;

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
