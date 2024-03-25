using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        string[] input = new string[0];

        string result = Orders.Order(input);
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        string[] input = new string[] { "Beer 2 1", "Beer 3 2" };
        
        string result = Orders.Order(input);
        string expectedResult = "Beer -> 9.00";

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        string[] input = new string[] { "Juice 2 2", "Juice 3.2043 2" };

        string result = Orders.Order(input);
        string expectedResult = "Juice -> 12.82";

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        string[] input = new string[] { "Water 2 2.8", "Water 3 2.0", "Water 1 1.5" };

        string result = Orders.Order(input);
        string expectedResult = "Water -> 6.30";

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
