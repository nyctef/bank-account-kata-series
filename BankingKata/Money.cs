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
    }
}
