using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new();
        Dictionary<string, int> dict2 = new();

        Dictionary<string, int> expected = new();

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);    

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "orange", 2 },
            { "banana", 5 },
            { "apple", 3 }
        };

        Dictionary<string, int> dict2 = new();

        Dictionary<string, int> expected = new();

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "orange", 2 },
            { "banana", 5 },
            { "apple", 3 }
        };

        Dictionary<string, int> dict2 = new()
        {
            { "strawberry", 10 },
            { "pear", 20 },
            { "mango", 25 }
        };

        Dictionary<string, int> expected = new();

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "orange", 2 },
            { "banana", 5 },
            { "apple", 3 },
            { "strawberry", 10 },
            { "mango", 25 }
        };

        Dictionary<string, int> dict2 = new()
        {
            { "strawberry", 10 },
            { "pear", 20 },
            { "mango", 25 }
        };

        Dictionary<string, int> expected = new()        
        {
            { "strawberry", 10 },
            { "mango", 25 }
        };
        
        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "orange", 2 },
            { "banana", 5 },
            { "apple", 3 },
            { "strawberry", 15 },
            { "mango", 26 }
        };

        Dictionary<string, int> dict2 = new()
        {
            { "strawberry", 10 },
            { "pear", 20 },
            { "mango", 25 }
        };

        Dictionary<string, int> expected = new();

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
