using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class SentenceAnalyzerTests
{
    [Test]
    public void Test_Analyze_EmptyString_ReturnsEmptyDictionary()
    {
        //Arrange
        string input = string.Empty;
        Dictionary<string, int> symbols = new Dictionary<string, int>();
        Dictionary<string, int> expectedResult = new ();

        //Act
        Dictionary<string, int> actualResult = SentenceAnalyzer.Analyze(input);

        //Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Analyze_SingleLetter_ReturnsDictionaryWithSingleLetterEntry()
    {
        //Arrange
        string input = "e";
        Dictionary<string, int> symbols = new Dictionary<string, int>();

        Dictionary<string, int> expectedResult = new()
        {
            { "letters", 1 }
        };

        //Act
        Dictionary<string, int> actualResult = SentenceAnalyzer.Analyze(input);

        //Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Analyze_SingleDigit_ReturnsDictionaryWithSingleDigitEntry()
    {
        //Arrange
        string input = "8";
        Dictionary<string, int> symbols = new Dictionary<string, int>();

        Dictionary<string, int> expectedResult = new()
        {
            { "digits", 1 }
        };

        //Act
        Dictionary<string, int> actualResult = SentenceAnalyzer.Analyze(input);

        //Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Analyze_WholeSentence_ReturnsDictionaryWithAllSymbolTypesCount()
    {
        //Arrange
        string input = "Mystring! 028";
        Dictionary<string, int> symbols = new Dictionary<string, int>();

        Dictionary<string, int> expectedResult = new()
        {
            { "letters", 8 },
            { "digits", 3 },
            { "special characters", 1 }
        };

        //Act
        Dictionary<string, int> actualResult = SentenceAnalyzer.Analyze(input);

        //Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}

