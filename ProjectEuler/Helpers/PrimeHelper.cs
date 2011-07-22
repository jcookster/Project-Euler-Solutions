using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Helpers
{
    class PrimeHelper
    {
        /// <summary>
        /// Check if a number is a prime
        /// </summary>
        /// <param name="number">The number to check for primality</param>
        /// <returns>Whether or not that number is a prime</returns>
        public static bool isPrime(long number)
        {
            // We can start out with the square root of that number. 
            // We won't need anythign bigger.
            long sqrt = (long)Math.Ceiling(Math.Sqrt(number));
            bool isPrime = true;

            // We don't want to check the even numbers. This
            // sets us up so we start out with an odd number
            if (sqrt % 2 == 0) 
            {
                sqrt++;
            }

            // Now check all the numbers.
            for (long i = sqrt; i > 2; i-=2)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}
