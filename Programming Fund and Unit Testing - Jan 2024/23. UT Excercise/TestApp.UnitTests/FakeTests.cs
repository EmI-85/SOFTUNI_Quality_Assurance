using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        char[] input = new char[] { '0', 'm', '1', 'a', 'l' };
        char[] expected = new char[] { 'm', 'a', 'l' };

        char[] actual = Fake.RemoveStringNumbers(input);

        Assert.That(actual,Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        char[] input = new char[] { 'o', 'm', 'a', 'l' };
        char[] expected = input;

        char[] actual = Fake.RemoveStringNumbers(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        char[]? input = null; 

        Assert.That(() => Fake.RemoveStringNumbers(input), Throws.ArgumentNullException);
    }
}
