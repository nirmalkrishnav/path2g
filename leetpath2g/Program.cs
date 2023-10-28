using System;

namespace Application
{
    public class Solution
    {
        #region running-sum-of-1d-array
        //https://leetcode.com/problems/running-sum-of-1d-array/description/
        // public void RunningSumOf1dArray()
        // {
        //     int[] nums = { 1, 2, 3, 4 };
        //     for (int i = 1; i < nums.Length; i++)
        //     {
        //         nums[i] += nums[i - 1];
        //     }
        //     Console.WriteLine(nums);
        // }
        #endregion

        #region richest-customer-wealth
        //https://leetcode.com/problems/richest-customer-wealth/

        public int MaximumWealth(int[][] accounts)
        {
            int max = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int currentMax = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    currentMax += accounts[i][j];
                }
                if (currentMax > max)
                {
                    max = currentMax;
                }
            }
            return max;
        }
        #endregion
    }
}
