using System;

using NUnit.Framework;
using TestApp.Chat;

namespace TestApp.Tests;

[TestFixture]
public class ChatRoomTests
{
    private ChatRoom _chatRoom = null!;
    
    [SetUp]
    public void Setup()
    {
        this._chatRoom = new();
    }
    
    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        string sender = "Desislava";
        string message = "You are the best!";
                                
        _chatRoom.SendMessage(sender, message);
        string actualResult = _chatRoom.DisplayChat();

        Assert.That(actualResult, Does.Contain("Chat Room Messages:"));
        Assert.That(actualResult, Does.Contain("Desislava: You are the best! - Sent at "));

    }

    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        string actualResult = _chatRoom.DisplayChat();

        Assert.That(actualResult, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        string sender1 = "Desislava";
        string message1 = "You are the best!";
        string sender2 = "Emi";
        string message2 = "Thank you!";
                                
        _chatRoom.SendMessage(sender1, message1);
        _chatRoom.SendMessage(sender2, message2);
        string actualResult = _chatRoom.DisplayChat();

        Assert.That(actualResult, Does.Contain("Chat Room Messages:"));
        Assert.That(actualResult, Does.Contain("Desislava: You are the best! - Sent at "));
        Assert.That(actualResult, Does.Contain("Emi: Thank you! - Sent at "));
    }
}
