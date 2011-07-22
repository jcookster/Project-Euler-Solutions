﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Interfaces;

namespace ProjectEuler.Problems
{
    

    /// <summary>
    /// Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
    /// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    /// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
    /// </summary>
    class Problem2 : IProblem
    {
        #region CONSTANTS

        // The problem number
        private const int PROBLEM_NUMBER = 2;
        private const int BOUND = 4000000;
        #endregion

        /// <summary>
        /// The answer to problem 2
        /// </summary>
        /// <returns>Answer to problem 2</returns>
        public decimal  Answer()
        {
            int sum = 0;
            int i = 1;
            int j = 2;

            // Don't go over our upper bound (4 million).
            while (i < BOUND)
            {
                // Is it an even term? If So we care about it.
                if (i % 2 == 0)
                {
                    sum += i;
                }

                // Do Some swapping.
                int temp = j;
                j = i + j;
                i = temp;
            }

            return sum;
        }

        /// <summary>
        /// Which problem are we?
        /// </summary>
        /// <returns>The Problem Number</returns>
        public int  ProblemNumber()
        {
            return PROBLEM_NUMBER;
        }
    }
}
    