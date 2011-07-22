using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Helpers;
using ProjectEuler.Interfaces;

namespace ProjectEuler.Problems
{
    /*
     * A palindromic number reads the same both ways. 
     * The largest palindrome made from the product of two 2-digit numbers is 9009 = 91  99.
     * Find the largest palindrome made from the product of two 3-digit numbers.
     */
    class Problem4 : IProblem
    {

        #region CONSTANTS

        // The problem number
        private const int PROBLEM_NUMBER = 4;

        #endregion

        /// <summary>
        /// The answer to problem 4
        /// </summary>
        /// <returns>Answer to problem 4</returns>
        public decimal Answer()
        {
            int max = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = i; j < 1000; j++)
                {
                    int product = j * i;
                    if (PalindromeHelper.isPalindrome(product) && product > max)
                    {
                        max = product;
                    }
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
