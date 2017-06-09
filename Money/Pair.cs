namespace Money
{
    public class Pair
    {
        private string @from;
        private string to;

        public Pair(string from, string to)
        {
            this.@from = from;
            this.to = to;
        }

        public bool @equals(object foo)
        {
            var pair = (Pair) foo;
            return @from.Equals(pair.@from) && to.Equals(pair.to);
        }

        public int hashCode()
        {
            return 0;
        }
    }
}