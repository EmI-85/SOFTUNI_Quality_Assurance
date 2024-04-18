using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        //Arrange
        Dictionary<string, int> fruitsDict = new()
        {
            { "apple", 5},
            { "banana", 15},
            { "orange", 25},
        };
        string searchedFruit = "banana";
        int expected = 15;

        //Act
        int result = Fruits.GetFruitQuantity(fruitsDict, searchedFruit);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        //Arrange
        Dictionary<string, int> fruitsDict = new()
        {
            { "apple", 5},
            { "banana", 15},
            { "orange", 25},
        };
        string searchedFruit = "kiwi";
        int expected = 0;

        //Act
        int result = Fruits.GetFruitQuantity(fruitsDict, searchedFruit);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        //Arrange
        Dictionary<string, int> fruitsDict = new();
        string searchedFruit = "banana";
        int expected = 0;

        //Act
        int result = Fruits.GetFruitQuantity(fruitsDict, searchedFruit);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        //Arrange
        Dictionary<string, int> fruitsDict = null;
        string searchedFruit = "banana";
        int expected = 0;

        //Act
        int result = Fruits.GetFruitQuantity(fruitsDict, searchedFruit);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        //Arrange
        Dictionary<string, int> fruitsDict = new()
        {
            { "apple", 5},
            { "banana", 15},
            { "orange", 25},
        };
        string searchedFruit = null;
        int expected = 0;

        //Act
        int result = Fruits.GetFruitQuantity(fruitsDict, searchedFruit);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
