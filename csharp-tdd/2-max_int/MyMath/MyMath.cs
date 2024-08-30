using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Represents a class that contains operations for integers.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Returns the maximum integer from a list of integers.
       /// </summary>
        /// <param name="nums">List</param>
        /// <returns>int</returns>
        public static int Max(List<int> nums)
        {
            // If list is null or empty, return 0
            if (nums == null || nums.Count <= 0)
            {
                return 0;
            }
            int max = nums[0];

            foreach (var value in nums)
            {
                max = Math.Max(max, value);
            }
            return max;
        }
    }
}