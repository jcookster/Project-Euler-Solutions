using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Interfaces;
using ProjectEuler.Helpers;

namespace ProjectEuler.Problems
{
    /*
     * The prime factors of 13195 are 5, 7, 13 and 29.
     *  What is the largest prime factor of the number 600851475143 ?
     */ 
    class Problem3 : IProblem
    {

        #region CONSTANTS

        // The problem number
        private const int PROBLEM_NUMBER = 3;

        private const long LARGE_PRIME = 600851475143;

        #endregion

        /// <summary>
        /// The answer to problem 3
        /// </summary>
        /// <returns>Answer to problem 3</returns>
        public decimal Answer()
        {
            // We can start out with the square root of the prime
            // There won't be any numbers higher than that.
            long sqrt = (long)Math.Ceiling(Math.Sqrt(LARGE_PRIME));
            long max = 0;

            for (long i = sqrt; i > 1; i--)
            {
                // If our number is a prime and the large prime is divisible by it, we have
                // a contender.
                if (PrimeHelper.isPrime(i) && LARGE_PRIME % i == 0)
                {
                    max = i;
                    break;
                }
            }
            return max;
        }

        /// <summary>
        /// Which problem are we?
        /// </summary>
        /// <returns>The Problem Number</returns>
        public int ProblemNumber()
        {
            return PROBLEM_NUMBER;
        }
    }
}
