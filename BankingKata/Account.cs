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
            balance = balance + money;
        }

        public void PrintBalance(IPrinter printer)
        {
            printer.PrintMoney(balance);
        }

        public void Withdraw(Money money)
        {
            if (balance >= money)
            {
                balance = balance - money;
                return;
            }
            throw new NotEnoughMoneyException();
        }
    }
}
