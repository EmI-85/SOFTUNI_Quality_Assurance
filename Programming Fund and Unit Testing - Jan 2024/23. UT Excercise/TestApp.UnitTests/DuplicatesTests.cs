using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] actualResult = Duplicates.RemoveDuplicates(numbers);
        int[] expectedResult = Array.Empty<int>();

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] numbers = new int[] { 1, 3, 4, 8, 17 };

        // Act
        int[] actualResult = Duplicates.RemoveDuplicates(numbers);
        int[] expectedResult = { 1, 3, 4, 8, 17 };

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] numbers = new int[] { 1, 3, 3, 4, 8, 8, 17 };

        // Act
        int[] actualResult = Duplicates.RemoveDuplicates(numbers);
        int[] expectedResult = { 1, 3, 4, 8, 17 };

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        int[] numbers = new int[] { 4, 4, 4, 4, 4 };

        int[] actualResult = Duplicates.RemoveDuplicates(numbers);
        int[] expectedResult = { 4 };

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}
