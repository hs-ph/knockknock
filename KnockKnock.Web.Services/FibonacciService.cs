using System;

namespace KnockKnock.Web.Services
{
    public class FibonacciService : IFibonacciService
    {
        public long Calculate(string count)
        {
            long c;
            if (!long.TryParse(count, out c)) throw new ArgumentException(nameof(count));
            if (-92 >c || c > 92) throw new ArgumentOutOfRangeException();

            return c >= 0 ? PositiveCount(c) : NegativeCount(c);
        }

        private long PositiveCount(long count)
        {
            long a = 0;
            long b = 1;
            long c = 0;
            for (long i = 0; i < count; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return a;
        }

        private long NegativeCount(long count)
        {
            long a = 0;
            long b = 1;
            long c = 0;
            for (long i = -1; i > count; i--)
            {
                c = a - b;
                a = b;
                b = c;
            }

            return b;
        }
    }
}