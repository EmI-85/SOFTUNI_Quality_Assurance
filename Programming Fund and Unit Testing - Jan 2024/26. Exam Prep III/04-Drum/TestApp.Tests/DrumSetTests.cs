﻿using NUnit.Framework;
using System;

using System.Collections.Generic;

namespace TestApp.Tests;

public class DrumSetTests
{
    [Test]
    public void Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException()
    {
        decimal money = 1000;
        List<int> initialQuality = new List<int>()
        {
            10, 20, 30
        };
        List<string> commands = new List<string>()
        {
            "5", "5","5"
        };

        Assert.Throws<ArgumentException>(() => DrumSet.Drum(money, initialQuality, commands), "Terminate command not given!");
    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {
        decimal money = 1000;
        List<int> initialQuality = new List<int>()
        {
            10, 20, 30
        };
        List<string> commands = new List<string>()
        {
            "5", "Pesho","Hit it again, Gabsy!"
        };

        Assert.Throws<ArgumentException>(() => DrumSet.Drum(money, initialQuality, commands), "Number did not parse correctly!");
    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 1000;
        List<int> initialQuality = new List<int>()
        {
            10, 20, 30
        };
        List<string> commands = new List<string>()
        {
            "5", "5", "15", "Hit it again, Gabsy!", "5"
        };

        string expectedResult = "10 20 5\nGabsy has 880.00lv.";
        string actualResult = DrumSet.Drum(money,initialQuality, commands);

        Assert.That(actualResult, Is.EqualTo(expectedResult));

    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 0;
        List<int> initialQuality = new List<int>()
        {
            10, 20, 30
        };
        List<string> commands = new List<string>()
        {
            "5", "5", "15", "Hit it again, Gabsy!", "5"
        };

        string expectedResult = "5\nGabsy has 0.00lv.";
        string actualResult = DrumSet.Drum(money, initialQuality, commands);

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 30;
        List<int> initialQuality = new List<int>()
        {
            10, 20, 30
        };
        List<string> commands = new List<string>()
        {
            "5", "5", "15", "5", "Hit it again, Gabsy!", "5"
        };

        string expectedResult = "\nGabsy has 30.00lv.";
        string actualResult = DrumSet.Drum(money, initialQuality, commands);

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
