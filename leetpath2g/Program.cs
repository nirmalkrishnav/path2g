using System;
// https://leetcode.com/problems/running-sum-of-1d-array/description/
int[] nums = { 1, 2, 3, 4 };
for (int i = 1; i < nums.Length; i++)
{
    nums[i] += nums[i - 1];
}
Console.WriteLine(nums);