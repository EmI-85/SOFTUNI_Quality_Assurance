﻿using System;

using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        //Arrange
        string taskName = "First Task";
        DateTime dateTime = DateTime.Parse("01.01.2025");

        string expectedContainsTask = "[ ] First Task - Due: ";

        //Act
        _toDoList.AddTask(taskName, dateTime);
        string result = _toDoList.DisplayTasks();

        //Assert
        Assert.That(result.Contains(expectedContainsTask), Is.True);
    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        //Arrange
        string taskName = "First Task";
        DateTime dateTime = DateTime.Parse("01.01.2025");

        string expectedContainsTask = "[✓] First Task - Due: ";
       

        //Act
        _toDoList.AddTask(taskName, dateTime);
        _toDoList.CompleteTask(taskName);
        string result = _toDoList.DisplayTasks();
        //Assert
        Assert.That(result.Contains(expectedContainsTask), Is.True);
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        //Arrange
        string taskName = "First Task";
        DateTime dateTime = DateTime.Parse("01.01.2025");

        //Act + Assert
        _toDoList.AddTask(taskName, dateTime);
                     
        Assert.That(() => _toDoList.CompleteTask("unknown"), Throws.ArgumentException);
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        //Arrange

        string expectedHeader = "To-Do List:";

        //Act
        string result = _toDoList.DisplayTasks();

        //Assert
        Assert.That(result.Contains(expectedHeader), Is.True);
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        //Arrange
        string taskName = "First Task";
        DateTime dateTime = DateTime.Parse("01.01.2025");
        string taskName2 = "Second Task";
        DateTime dateTime2 = DateTime.Today;

        string expectedContainsTask = "[ ] First Task - Due: ";
        string expectedContainsTask2 = "[✓] Second Task - Due: ";

        //Act
        _toDoList.AddTask(taskName, dateTime);
        _toDoList.AddTask(taskName2, dateTime2);
        _toDoList.CompleteTask(taskName2);

        string result = _toDoList.DisplayTasks();

        //Assert
        bool isContained = result.Contains(expectedContainsTask) && result.Contains(expectedContainsTask2);
        Assert.That(isContained, Is.True);
    }
}
