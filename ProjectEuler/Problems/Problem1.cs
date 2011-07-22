using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Interfaces;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    class Problem1 : IProblem
    {
        #region CONSTANTS
        
        // The problem number
        private const int PROBLEM_NUMBER = 1;

        // Find all of the multiples below the max.
        private const int MAX = 1000;
        
        #endregion

        /// <summary>
        /// The answer to problem 1
        /// </summary>
        /// <returns>Answer to problem 1</returns>
        public decimal Answer()
        {
            int sum = 0;

            // Pretty basic use of the modulus operator. Find out if
            // it is a multiple of three or 5. 
            for (int i = 1; i < MAX; i++)
            {

                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }

            }

            return sum;
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
