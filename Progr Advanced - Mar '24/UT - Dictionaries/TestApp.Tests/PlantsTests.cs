using NUnit.Framework;

using System;
using System.Numerics;
using System.Text;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        string[] input = new string[0];

        string result = Plants.GetFastestGrowing(input);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        string[] input = new string[] { "Jivko" };
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Plants with 5 letters:");
        sb.AppendLine("Jivko");
        string expectedResult = sb.ToString().TrimEnd();

        string result = Plants.GetFastestGrowing(input);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        string[] input = new string[] { "Jivko", "Eli", "Emiliya" };
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Plants with 3 letters:");
        sb.AppendLine("Eli");
        sb.AppendLine("Plants with 5 letters:");
        sb.AppendLine("Jivko");
        sb.AppendLine("Plants with 7 letters:");
        sb.AppendLine("Emiliya");
        string expectedResult = sb.ToString().TrimEnd();

        string result = Plants.GetFastestGrowing(input);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        string[] input = new string[] { "JIVko", "IvO", "Iva", "EMiliYA", "Emiliya" };
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Plants with 3 letters:");
        sb.AppendLine("IvO");
        sb.AppendLine("Iva");
        sb.AppendLine("Plants with 5 letters:");
        sb.AppendLine("JIVko");
        sb.AppendLine("Plants with 7 letters:");
        sb.AppendLine("EMiliYA");
        sb.AppendLine("Emiliya");
        string expectedResult = sb.ToString().TrimEnd();

        string result = Plants.GetFastestGrowing(input);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
