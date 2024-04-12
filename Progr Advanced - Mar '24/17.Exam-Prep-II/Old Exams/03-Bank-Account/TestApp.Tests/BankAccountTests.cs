using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        //Arrange
        double initialAmount = 1000;

        //Act
        BankAccount account = new BankAccount(initialAmount);

        //Assert
        Assert.That(account.Balance, Is.EqualTo(initialAmount));
    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        //Arrange
        double initialAmount = 1000;
        double additionalMoney = 500;

        double expectedMoney = 1500;

        //Act
        BankAccount account = new BankAccount(initialAmount);
        account.Deposit(additionalMoney);

        //Assert
        Assert.That(account.Balance, Is.EqualTo(expectedMoney));
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        //Arrange
        double initialAmount = 1000;
        double additionalMoney = -500;

        //Act + Assert
        BankAccount account = new BankAccount(initialAmount);
        Assert.That(() => account.Deposit(additionalMoney), Throws.ArgumentException);
    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        //Arrange
        double initialAmount = 1000;
        double getMoney = 400;

        double expectedMoney = 600;

        //Act
        BankAccount account = new BankAccount(initialAmount);
        account.Withdraw(getMoney);

        //Assert
        Assert.That(account.Balance, Is.EqualTo(expectedMoney));
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        //Arrange
        double initialAmount = 1000;
        double getMoney = -400;

        //Act + Assert
        BankAccount account = new BankAccount(initialAmount);
        Assert.That(() => account.Withdraw(getMoney),Throws.ArgumentException);
    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        //Arrange
        double initialAmount = 1000;
        double getMoney = -1400;

        //Act + Assert
        BankAccount account = new BankAccount(initialAmount);
        Assert.That(() => account.Withdraw(getMoney), Throws.ArgumentException);
    }
}
