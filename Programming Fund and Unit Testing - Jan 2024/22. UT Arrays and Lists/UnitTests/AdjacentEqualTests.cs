using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string result = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> testList = new() {1, 20, 30, 4, 5};

        // Act
        string result = AdjacentEqual.Sum(testList);
        string expected = "1 20 30 4 5";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> testList = new() { 1, 2, 2, 5 };

        // Act
        string result = AdjacentEqual.Sum(testList);
        string expected = "1 4 5";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> testList = new() { 2, 2, 2, 2 };

        // Act
        string result = AdjacentEqual.Sum(testList);
        string expected = "8";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> testList = new() { 2, 2, 9, 8 };

        // Act
        string result = AdjacentEqual.Sum(testList);
        string expected = "4 9 8";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> testList = new() { 1, 2, 9, 9 };

        // Act
        string result = AdjacentEqual.Sum(testList);
        string expected = "1 2 18";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> testList = new() { 1, 2, 9, 9, 3 ,8 };

        // Act
        string result = AdjacentEqual.Sum(testList);
        string expected = "1 2 18 3 8";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
