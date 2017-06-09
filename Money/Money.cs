namespace Money
{
    public class Money : Expression
    {
        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public static Money dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Franc franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public Expression Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }

        public int amount;

        private string currency;

        public override bool Equals(object value)
        {
            var money = (Money)value;
            return amount == money.amount 
                && currency == money.currency;
        }

        public Money reduce(Bank bank, string to)
        {
            var rate = bank.rate(currency, to);
            return new Money(amount / rate, to);
        }

        public virtual string Currency()
        {
            return currency;
        }

        public override string ToString()
        {
            return amount + " " + currency;
        }

        public Expression plus(Expression addend)
        {
            return new Sum(this, addend);
        }

        public Expression times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }
    }
}