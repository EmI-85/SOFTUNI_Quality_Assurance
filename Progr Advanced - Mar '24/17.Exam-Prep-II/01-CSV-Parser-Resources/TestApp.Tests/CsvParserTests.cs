using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        //Arrange
        string input = string.Empty;

        //Act
        string[] result = CsvParser.ParseCsv(input);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        //Arrange
        string input = "single element";
        string[] expected = 
        { 
            "single element" 
        };

        //Act
        string[] result = CsvParser.ParseCsv(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        string input = "first,second,third";
        string[] expected =
        {
            "first",
            "second",
            "third"
        };

        //Act
        string[] result = CsvParser.ParseCsv(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        string input = "  first  ,  second  , third   ";
        string[] expected =
        {
            "first",
            "second",
            "third"
        };
    }
}
