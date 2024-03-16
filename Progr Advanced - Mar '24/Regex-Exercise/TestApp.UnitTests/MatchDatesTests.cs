using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class MatchDatesTests
{

    [TestCase("31-Dec-2022", "Day: 31, Month: Dec, Year: 2022")]
    [TestCase("31.Dec.2022", "Day: 31, Month: Dec, Year: 2022")]
    [TestCase("31/Dec/2022", "Day: 31, Month: Dec, Year: 2022")]
    //[TestCase("31\Dec\2022", "Day: 31, Month: Dec, Year: 2022")]
    [TestCase("31 Dec 2022", "")]
    [TestCase("", "")]
    [TestCase("13-Jan-2024 31-Dec-2022", "Day: 13, Month: Jan, Year: 2024")]
    [TestCase("31-Dec/2022", "")]
    [TestCase("31-De.2022", "")]
    //[TestCase("41-Dec-2022", "")]
    [TestCase("0-Dec-2022", "")]
    [TestCase("31-Dec-22", "")]

    public void Test_Match_ValidDate_ReturnsExpectedResult(string input, string expected)
    {
        string result = MatchDates.Match(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => MatchDates.Match(null));
    }
}
