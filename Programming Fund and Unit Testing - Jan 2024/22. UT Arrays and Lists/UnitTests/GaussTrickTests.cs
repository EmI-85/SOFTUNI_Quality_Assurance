using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> currentList = new() {8};

        // Act
        List<int> result = GaussTrick.SumPairs(currentList); ;

        // Assert
        CollectionAssert.AreEqual(currentList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        List<int> currentList = new() { 15, 8, 2, 14 };

        // Act
        List<int> result = GaussTrick.SumPairs(currentList);
        List<int> expected = new() { 29, 10 };

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        List<int> currentList = new() { 15, 8, 2, 14, 9 };

        // Act
        List<int> result = GaussTrick.SumPairs(currentList);
        List<int> expected = new() { 24, 22, 2 };

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        List<int> currentList = new() { 115, 38, 2, 14, 1009, 920, 777, 484 };
        // Act
        List<int> result = GaussTrick.SumPairs(currentList);
        List<int> expected = new() { 599, 815, 922, 1023 };

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        List<int> currentList = new() { 115, 38, 2, 14, 5, 1009, 920, 777, 484 };

        // Act
        List<int> result = GaussTrick.SumPairs(currentList);
        List<int> expected = new() { 599, 815, 922, 1023, 5 };

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
