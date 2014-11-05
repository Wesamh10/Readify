using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadifyServiceApplication.Managers
{
    public class FibonacciNumberManager
    {
        public long FibonacciNumber(long n)
        {
            // check if even number
            var isEven = (n % 2) == 0;
            // convert number to positive number
            n = Math.Abs(n);
            // throw exception if the number > 92 to avoid overflow
            if (n > 92)
                throw new ArgumentOutOfRangeException("n", "Fib(<92) will cause a 64-bit integer overflow.");
            // special case for fibonacci
            if (n == 1 || n == 2)
            {
                return 1;
            }
            long a = 1;
            long b = 1;
            long c = 0;
            // calculate the fibonacci number
            for (uint i = 3; i <= n; i++)
            {
                c = b + a;
                a = b;
                b = c;
            }
            return (isEven ? c * -1 : c);
        }
    }
}