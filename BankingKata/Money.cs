using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingKata
{
    public class Money
    {
        private readonly int amount;

        public Money(int amount)
        {
            this.amount = amount;
        }

        public override bool Equals(Object other)
        {
            var otherAmount = ((Money)other).amount;
            return this.amount == otherAmount;
        }

        public static Money operator+(Money left, Money right)
        {
            var leftAmount = left.amount;
            var rightAmount = right.amount;
            return new Money(leftAmount + rightAmount);
        }

        public static Money operator-(Money left, Money right)
        {
            var leftAmount = left.amount;
            var rightAmount = right.amount;
            return new Money(leftAmount - rightAmount);
        }

        public static bool operator>=(Money left, Money right)
        {
            var leftAmount = left.amount;
            var rightAmount = right.amount;
            return leftAmount >= rightAmount;
        }

        public static bool operator <=(Money left, Money right)
        {
            var leftAmount = left.amount;
            var rightAmount = right.amount;
            return leftAmount <= rightAmount;
        }
    }
}
