using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class EmployeeManagementSystemTests
{
    [Test]
    public void Test_Constructor_CheckInitialEmptyEmployeeCollectionAndCount()
    {
        //Arrange
        EmployeeManagementSystem employeeManagementSystem = new EmployeeManagementSystem();

        int expectedCount = 0;
        //Act
        int actualResult = employeeManagementSystem.EmployeeCount;
        //Assert
        Assert.That(actualResult, Is.EqualTo(expectedCount));
    }

    [Test]
    public void Test_AddEmployee_ValidEmployeeName_AddNewEmployee()
    {
        //Arrange
        string employeeName = "Ivan Petrov";

        List<string> expectedResult = new ()
        { 
            "Ivan Petrov" 
        };

       //Act
       EmployeeManagementSystem employeeManagementSystem = new EmployeeManagementSystem();
       employeeManagementSystem.AddEmployee(employeeName);
       List<string> actualResult = employeeManagementSystem.GetAllEmployees();

       //Assert
       //Assert.That(actualResult, Is.EqualTo(expectedResult));
       CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_AddEmployee_NullOrEmptyEmployeeName_ThrowsArgumentException()
    {
        //Arrange
        string employeeName = string.Empty;

        //Act + Assert
        EmployeeManagementSystem employeeManagementSystem = new EmployeeManagementSystem();
        
        Assert.That(() => employeeManagementSystem.AddEmployee(employeeName), Throws.ArgumentException);

    }

    [Test]
    public void Test_RemoveEmployee_ValidEmployeeName_RemoveFirstEmployeeName()
    {
        //Arrange
        string employeeName1 = "Ivan Petrov";
        string employeeName2 = "Ivan Ivanov";

        List<string> expectedResult = new()
        {
            "Ivan Ivanov"
        };

        //Act
        EmployeeManagementSystem employeeManagementSystem = new EmployeeManagementSystem();
        employeeManagementSystem.AddEmployee(employeeName1);
        employeeManagementSystem.AddEmployee(employeeName2);

        employeeManagementSystem.RemoveEmployee(employeeName1);
        List<string> actualResult = employeeManagementSystem.GetAllEmployees();

        //Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_RemoveEmployee_NullOrEmptyEmployeeName_ThrowsArgumentException()
    {
        //Arrange
        string employeeName = string.Empty;

        //Act + Assert
        EmployeeManagementSystem employeeManagementSystem = new EmployeeManagementSystem();

        Assert.That(() => employeeManagementSystem.RemoveEmployee(employeeName), Throws.ArgumentException);

    }

    [Test]
    public void Test_GetAllEmployees_AddedAndRemovedEmployees_ReturnsExpectedEmployeeCollection()
    {
        //Arrange
        string employeeName1 = "Ivan Petrov";
        string employeeName2 = "Ivan Ivanov";
        string employeeName3 = "Maria Ivanova";

        List<string> expectedResult = new()
        {
            "Ivan Petrov",
            "Maria Ivanova"
        };

        //Act
        EmployeeManagementSystem employeeManagementSystem = new EmployeeManagementSystem();
        employeeManagementSystem.AddEmployee(employeeName1);
        employeeManagementSystem.AddEmployee(employeeName2);
        employeeManagementSystem.AddEmployee(employeeName3);

        employeeManagementSystem.RemoveEmployee(employeeName2);
        List<string> actualResult = employeeManagementSystem.GetAllEmployees();

        //Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }   
}

