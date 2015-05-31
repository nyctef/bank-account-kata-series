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
            this.balance = new Money(0);
        }

        public void Deposit(Money money)
        {
            this.balance = this.balance.Plus(money);
        }

        public void PrintBalance(IPrinter printer)
        {
            printer.PrintMoney(this.balance);
        }
    }
}
