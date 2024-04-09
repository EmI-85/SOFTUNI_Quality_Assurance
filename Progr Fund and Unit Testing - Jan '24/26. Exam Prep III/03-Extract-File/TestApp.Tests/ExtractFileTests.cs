using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        string input = null;

        Assert.That(() => ExtractFile.GetFile(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        string input = string.Empty;
       
        Assert.That(() => ExtractFile.GetFile(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        string input = "C:\\Users\\emili\\Documents\\EMILIYA's DOCUMENTS\\Emiliya's documents\\SoftUni\\QA\\03. Progr Fund Unit Testing - 012024\\27. Exam Preparation III\\Еxam-Preparation-3.docx";

        string actual = ExtractFile.GetFile(input);
        string expected = "File name: Еxam-Preparation-3\nFile extension: docx";

        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        string input = "C:\\Users\\emili\\Documents\\EMILIYA's DOCUMENTS\\Emiliya's documents\\SoftUni\\QA\\03. Progr Fund Unit Testing - 012024\\27. Exam Preparation III\\Еxam-Preparation-3";

        string actual = ExtractFile.GetFile(input);
        string expected = "File name: Еxam-Preparation-3";

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        string input = "C:\\Users\\emili\\Documents\\EMILIYA's DOCUMENTS\\Emiliya's documents\\Soft&Uni\\QA\\03. Progr Fund Unit Testing - 012024\\27. Exam Preparation%III\\Еxam-Preparatio&n-3.docx";

        string actual = ExtractFile.GetFile(input);
        string expected = "File name: Еxam-Preparatio&n-3\nFile extension: docx";

        Assert.That(actual, Is.EqualTo(expected));
    }
}
