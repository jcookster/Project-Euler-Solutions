using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Helpers
{
    class PalindromeHelper
    {
        /// <summary>
        /// Check if a number is a palindromic number
        /// </summary>
        /// <param name="number">The number we want to check.</param>
        /// <returns>Whether we have a palindrome or not.</returns>
        public static bool isPalindrome(long number)
        {

            string convertedNumber = number.ToString();
            bool isPalindrome = true;
            int end = convertedNumber.Length;
            int start = 0;
            
            // Start at both ends and compare the string value.
            for (int i = end - 1; i >= (int)Math.Floor((decimal)end / 2); i--)
            {
                // Whenever we find two values that don't match, we don't have a palindrome.
                if (convertedNumber.ElementAt(i) != convertedNumber.ElementAt(start))
                {
                    isPalindrome = false;
                    break;
                }
                start++;
            }

            return isPalindrome;
        }
    }
}
