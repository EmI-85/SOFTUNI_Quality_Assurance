using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    [TestCase("https://softuni.bg", new string[] { "https://softuni.bg" })]
    [TestCase("https://www.softuni.bg", new string[] { "https://www.softuni.bg" })]
    [TestCase("http://softuni.bg", new string[] { "http://softuni.bg" })]
    [TestCase("http://www.softuni.bg", new string[] { "http://www.softuni.bg" })]
    //[TestCase("http://www.softuni.bg/blog", new string[] { "http://www.softuni.bg/blog" })]
    [TestCase("", new string[] { })]
    [TestCase("www.SoftUni", new string[] { })]
    [TestCase("https://softuni.bg?id=1484", new string[] { "https://softuni.bg?id=1484" })]
    [TestCase("https://softuni.bg https://judge.softuni.org https://github.com", new string[] { "https://softuni.bg", "https://judge.softuni.org", "https://github.com" })]


    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList(string input, string[] expected)
    {
        // Act
        List<string> result = MatchUrls.ExtractUrls(input);
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
