using System.ComponentModel;

namespace BankAccount.Test
{
    [Collection(nameof(BankAccountCollection))]
    public class BankAccountTests
    {
        Account _sut;

        public BankAccountTests(BankAccountFixture bankAccountFixture)
        {
            _sut = bankAccountFixture.RegularAccount;
        }

        // test for bankAccount

        [Theory]
        [InlineData(123445566)]
        [InlineData(123545799)]
        [InlineData(123434589)]
        [InlineData(123645576)]
        public void CanVerifyAccountNr(decimal accountNumber)
        {
            // Arrange
            
            _sut.BankAccountNumber = accountNumber;


            // Act
            var actual = _sut.VerifyAccountNumber();


            // Assert
            Assert.True(actual);
        }


        [Theory]
        [InlineData(1234455664)]
        [InlineData(1235457995)]
        [InlineData(1234345859)]
        [InlineData(1236455766)]
        public void CanVerifyFalseAccountNr(decimal accountNumber)
        {
            // Arrange            
            _sut.BankAccountNumber = accountNumber;


            // Act
            var actual = _sut.VerifyAccountNumber();


            // Assert
            Assert.False(actual);
        }



        [Fact]
        public void CanSendMoneyBetweenAccounts()
        {
            // arrange
            var jespersAccount = new Account();
            var andreasAccount = new Account();
            jespersAccount.Balance = 500;
            andreasAccount.Balance = 500;

            var bankAccountList = new List<Account>();

            bankAccountList.Add(jespersAccount);
            bankAccountList.Add(andreasAccount);
            // Act
            bankAccountList = Account.TransferMoney(bankAccountList);

            // Assert
            Assert.NotEqual(bankAccountList[0].Balance, bankAccountList[1].Balance);

        }




        [Theory]
        [InlineData(123, 45, 168)]
        [InlineData(100, 50, 150)]
        [InlineData(200, 200, 400)]
        public void CanDepositMoney(decimal initialBalance, decimal depositAmount, decimal expectedBalance)
        {
            // Arrange
            _sut.Balance = initialBalance;

            // Act
            _sut.Deposit(depositAmount);

            // Assert
            Assert.Equal(expectedBalance, _sut.Balance);
        }

        [Theory]
        [InlineData(100, 50, 50)]
        [InlineData(500, 450, 50)]
        public void CanWithdrawMoney(decimal balance,int withdrawal, int expected)
        {
            // Arrange
            _sut.Balance = balance;

            // Act
            _sut.Withdraw(withdrawal);

            // Assert
            Assert.Equal(expected, _sut.Balance);
        }

        [Fact]
        public void CannotDepositNegativeAmount()
        {
            // Arrange
            

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _sut.Deposit(-50));
        }

        [Fact]
        public void CannotWithdrawNegativeAmount()
        {
            // Arrange
            

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _sut.Withdraw(-50));
        }

        [Theory]
        [InlineData(100, 200)]
        [InlineData(50, 51)]
        public void CannotWithdrawAmountGreaterThanBalance(decimal initialBalance, decimal withdrawalAmount)
        {
            // Arrange
            _sut.Balance = initialBalance;

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => _sut.Withdraw(withdrawalAmount));
        }
    }
}