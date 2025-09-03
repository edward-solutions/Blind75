//https://leetcode.com/problems/maximum-subarray/
//[-2,1,-3,4,-1,2,1,-5,4] = 6
namespace Blind75.Core.Arrays_and_Hashing
{
    public static class MaximumSubarray
    {
        public static int Solution(int[] nums)
        {
            int currentSum = nums[0];
            int maxSum = nums[0];

            for(int i = 1; i < nums.Length; i++)
            {
                currentSum = int.Max(nums[i], nums[i] + currentSum);
                maxSum = int.Max(maxSum, currentSum);
            }
            return maxSum;
        }
    }
}
