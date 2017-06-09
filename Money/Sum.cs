namespace Money
{
    public class Sum : Expression
    {
        public Sum(Expression augend, Expression addend)
        {
            this.augend = augend;
            this.addend = addend;
        }

        public Expression augend { get; set; }

        public Expression addend { get; set; }

        public Money reduce(Bank bank, string to)
        {
            var amount = augend.reduce(bank, to).amount
                         + addend.reduce(bank, to).amount;
            return new Money(amount, to);
        }

        public Expression plus(Expression addend)
        {
            return new Sum(this, addend);
        }

        public Expression times(int multiplier)
        {
            return new Sum(augend.times(multiplier), addend.times(multiplier));
        }
    }
}
