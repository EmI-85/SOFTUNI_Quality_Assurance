using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchPhoneNumbersTests
{
    [TestCase(
        "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555",
        "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555")]
    [TestCase("359-2-124-5678, +159-2-124-5678, +351-2-124-5678, +359 2-124-5678, +359-1-124-5678, +359-2-14-5678, +359-2-124-57678, +359-2 124 5678, +359-2-124 5678, +359-124-5678", "")]
    [TestCase("","")]
    [TestCase(
        "+359-2-124-5678, +351-2-124-5678, +359 2 986 5432, +359-2-555-5555, ",
        "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555")]

    public void Test_Match_ValidPhoneNumbers_ReturnsMatchedNumbers(
        string phoneNumbers, string expectedResult)
    {
        // Act
        string result = MatchPhoneNumbers.Match(phoneNumbers);
        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
