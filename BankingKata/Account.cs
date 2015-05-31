using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingKata
{
    public class Account
    {
        private Money balance;

        public Account()
        {
            balance = new Money(0);
        }

        public void Deposit(Money money)
        {
            balance = balance.Plus(money);
        }

        public void PrintBalance(IPrinter printer)
        {
            printer.PrintMoney(balance);
        }

        public void Withdraw(Money money)
        {
            balance = balance.Minus(money);
        }
    }
}
