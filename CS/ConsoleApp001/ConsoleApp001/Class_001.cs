using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * Given an array of integers, return indices of the two numbers such that they add up to a specific target.
 *
 * You may assume that each input would have exactly one solution, and you may not use the same element twice.
 *
 * Example:
 * Given nums = [2, 7, 11, 15], target = 9,
 * Because nums[0] + nums[1] = 2 + 7 = 9,
 * return [0, 1].
 * */

namespace ConsoleApp001
{
    class Class_001
    {
        // Brute force method
        // Time: O(n^2)
        // Space: O(1)
        public static int[] TwoSum_01(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = nums.Length - 1; j > i; j--)
                {
                    if (i != j)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            return new int[] { i, j };
                        }
                    }
                }
            }
            return new int[] { };
        }
    }
}
