namespace Money
{

    public class Dollar : Money
    {
        public Dollar(int amount, string currency) : base(amount, currency)
        {
        }

        public static Money dollar(int amount)
        {
            return new Money(amount, "USD");
        }
    }
}