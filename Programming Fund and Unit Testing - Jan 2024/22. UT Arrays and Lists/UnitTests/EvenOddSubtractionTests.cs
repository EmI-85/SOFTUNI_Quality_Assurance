using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    // TODO: finish the test
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] currentArray = { 2, 4, 8, 6, 42};
        // Act
        int result = EvenOddSubtraction.FindDifference(currentArray);

        // Assert
        Assert.That(result, Is.EqualTo(62));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        int[] currentArray = { 7, 5, 9, 11, 37 };

        int result = EvenOddSubtraction.FindDifference(currentArray);

        Assert.That(result, Is.EqualTo(-69));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        int[] currentArray = { 6, 5, 9, 11, 22, 40, 63 };

        int result = EvenOddSubtraction.FindDifference(currentArray);

        Assert.That(result, Is.EqualTo(-20));
    }
}
