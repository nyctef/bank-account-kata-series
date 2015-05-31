using BankingKata;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingKataTests
{
    class DepositAndWithdrawalTests
    {
        [Test]
        public void CanDepositIntoAnAccount()
        {
            var account = new Account();
            account.Deposit(new Money(100));
            var printer = new Mock<IPrinter>();
            var mockPrinter = printer.Object;

            account.PrintBalance(mockPrinter);

            printer.Verify(x => x.PrintMoney(new Money(100)));
        }

        [Test]
        public void CanDepositTwiceIntoAnAccount()
        {
            var account = new Account();
            account.Deposit(new Money(100));
            account.Deposit(new Money(100));
            var printer = new Mock<IPrinter>();
            var mockPrinter = printer.Object;

            account.PrintBalance(mockPrinter);

            printer.Verify(x => x.PrintMoney(new Money(200)));
        }
    }
}
