using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        _exceptions = new();
    }

    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "banana";

        // Act
        string actualResult = _exceptions.ArgumentNullReverse(input);
        string expectedResult = "ananab";

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

   
    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [TestCase(100, 50, 50)]
    [TestCase(100, 20, 80)]
    [TestCase(50, 10, 45)]
    [TestCase(70, 30, 49)]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice(decimal totalPrice, decimal discount, decimal expectedValue)
    {
        decimal result = _exceptions.ArgumentCalculateDiscount(totalPrice, discount);

        Assert.That(result, Is.EqualTo(expectedValue));
    }

    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => 
                                _exceptions.ArgumentCalculateDiscount(80, -10), 
                         "Discount must be between 0 and 100.");
    }

    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
                                    _exceptions.ArgumentCalculateDiscount(80, 101),
                             "Discount must be between 0 and 100.");
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        int[] array = { 10, 20, 30, 40, 50 };
        int index = 2;

        int actualResult = _exceptions.IndexOutOfRangeGetElement(array, index);
        int expected = 30;

        Assert.That(actualResult, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = -5;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.Throws<IndexOutOfRangeException>(() => _exceptions.IndexOutOfRangeGetElement(array, index));
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length + 2;

        // Act & Assert
        Assert.Throws<IndexOutOfRangeException>(() => _exceptions.IndexOutOfRangeGetElement(array, index));
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        string result = _exceptions.InvalidOperationPerformSecureOperation(true);
        Assert.That(result, Is.EqualTo("User logged in."));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        Assert.Throws<InvalidOperationException>(() => _exceptions.InvalidOperationPerformSecureOperation(false),"User must be logged in to perform this operation.");
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        string input = "8";

        int actualResult = _exceptions.FormatExceptionParseInt(input);
        int expectedResult = 8;

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        string input = "_";

        Assert.Throws<FormatException>(() => _exceptions.FormatExceptionParseInt(input));
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        Dictionary<string, int> values = new Dictionary<string, int> ();
        values["stosho"] = 28;
        string lookupKey = "stosho";
        int expectedValue = 28;

        int result = _exceptions.KeyNotFoundFindValueByKey(values, lookupKey);

        Assert.That (result, Is.EqualTo(expectedValue));
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        Dictionary<string, int> values = new Dictionary<string, int>();
        values["softuni"] = 10;

        Assert.Throws<KeyNotFoundException>(() => _exceptions.KeyNotFoundFindValueByKey(values, "test"), "The specified key was not found in the dictionary.");
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        int num1 = 2340;
        int num2 = 2;

        int actualResult = _exceptions.OverflowAddNumbers(num1, num2);
        int expectedResult = 2342;

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        int num1 = int.MaxValue;
        int num2 = 200;

        Assert.Throws<OverflowException>(() => _exceptions.OverflowAddNumbers(num1, num2));
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        int num1 = int.MinValue;
        int num2 = -200;

        Assert.Throws<OverflowException>(() => _exceptions.OverflowAddNumbers(num1, num2));
    }

    [TestCase(10, 2, 5)]
    [TestCase(12, 6, 2)]
    [TestCase(-10, 2, -5)]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient(int divident, int divisor, int expectedResult)
    {
       int result = _exceptions.DivideByZeroDivideNumbers(divident, divisor);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => _exceptions.DivideByZeroDivideNumbers(10, 0), "Division by zero is not allowed.");
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        int[] array = { 10, 20, 30, 40, 50 };
        int index = 2;

        int actualResult = _exceptions.SumCollectionElements(array, index);
        int expected = 150;

        Assert.That(actualResult, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        int[] array = null ;
        int index = 2;

        Assert.Throws<ArgumentNullException>(() => _exceptions.SumCollectionElements(array, index));
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        int[] array = { 10, 20, 30, 40, 50 };
        int index = -6;

        Assert.Throws<IndexOutOfRangeException>(() => _exceptions.SumCollectionElements(array, index));
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        Dictionary<string, string> values = new()
        {
            ["stosho"] = "28"
        };
        string lookupKey = "stosho";
        int expectedValue = 28;
        
        int result = _exceptions.GetElementAsNumber(values, lookupKey);

        Assert.That(result, Is.EqualTo(expectedValue));
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        Dictionary<string, string> values = new()
        {
            ["softuni"] = "12"
        };
        string lookupKey = "test";

        Assert.Throws<KeyNotFoundException>(() => _exceptions.GetElementAsNumber(values, lookupKey));
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        Dictionary<string, string> values = new()
        {
            ["softuni"] = "qa"
        };
        string lookupKey = "softuni";

        Assert.Throws<FormatException>(() => _exceptions.GetElementAsNumber(values, lookupKey), "Can't parse string.");
    }
}
