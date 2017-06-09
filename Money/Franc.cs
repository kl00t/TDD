namespace Money
{
    public class Franc : Money
    {
        public Franc(int amount, string currency) : base(amount, currency)
        {
        }

        public static Money franc(int amount)
        {
            return new Money(amount, "CHF");
        }
    }
}