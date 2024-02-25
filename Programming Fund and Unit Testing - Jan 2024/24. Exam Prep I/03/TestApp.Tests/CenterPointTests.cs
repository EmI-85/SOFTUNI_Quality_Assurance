using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class CenterPointTests
{
    [Test]
    public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
    {
        // Arrange 
        double firstPointX = 1;
        double firstPointY = 1;

        double secondPointX = 2;
        double secondPointY = 2;

        // Act
        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondPointX, secondPointY);
        string expected = "(1, 1)";
        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
    {
        // Arrange 
        double firstPointX = 4;
        double firstPointY = 4;

        double secondPointX = 2;
        double secondPointY = 2;

        // Act
        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondPointX, secondPointY);
        string expected = "(2, 2)";
        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnFirstPoint()
    {
        // Arrange 
        double firstPointX = 2;
        double firstPointY = 2;

        double secondPointX = 2;
        double secondPointY = 2;

        // Act
        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondPointX, secondPointY);
        string expected = "(2, 2)";
        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint()
    {
        double firstPointX = -2;
        double firstPointY = -2;

        double secondPointX = 2;
        double secondPointY = 2;

        // Act
        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondPointX, secondPointY);
        string expected = "(-2, -2)";
        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint()
    {
        double firstPointX = 2;
        double firstPointY = 2;

        double secondPointX = -2;
        double secondPointY = -2;

        // Act
        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondPointX, secondPointY);
        string expected = "(-2, -2)";
        // Assert
        Assert.AreEqual(expected, result);
    }
}
