using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        Dictionary<string, int> gradesDict = new()
        {
            { "Ivan", 4 },
            { "Peter", 6 },
            { "Denis", 3 },
            { "Martin", 2 },
        };

        string expectedResult = "Peter with average grade 6.00"+
            Environment.NewLine +
            "Ivan with average grade 4.00"+
             Environment.NewLine +
             "Denis with average grade 3.00";

        string actualResult = Grades.GetBestStudents(gradesDict);

        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        Dictionary<string, int> gradesDict = new()
        {
        };

        string expectedResult = string.Empty;

        string actualResult = Grades.GetBestStudents(gradesDict);

        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        Dictionary<string, int> gradesDict = new()
        {
            { "Ivan", 3 },
            { "Peter", 4 }
        };

        string expectedResult = "Peter with average grade 4.00" +
            Environment.NewLine +
            "Ivan with average grade 3.00";

        string actualResult = Grades.GetBestStudents(gradesDict);

        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        Dictionary<string, int> gradesDict = new()
        {
            { "Ivan", 6 },
            { "Peter", 6 },
            { "Denis", 6 },
            { "Martin", 2 },
        };

        string expectedResult = "Denis with average grade 6.00" +
            Environment.NewLine +
            "Ivan with average grade 6.00" +
             Environment.NewLine +
             "Peter with average grade 6.00";

        string actualResult = Grades.GetBestStudents(gradesDict);

        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }
}
