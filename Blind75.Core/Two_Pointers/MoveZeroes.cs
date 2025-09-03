//https://leetcode.com/problems/move-zeroes/description/

//[1,0,0,3,12]

namespace Blind75.Core.Two_Pointers
{
    public static class MoveZeroes
    {
        public static void Solution(int[] nums)
        {
            int left = 0;
            int right = 0;

            while (right < nums.Length)
            {
                if (nums[right] != 0)
                {
                    int temp = nums[right];
                    nums[right] = nums[left];
                    nums[left] = temp;
                    left++;
                }
                right++;
            }
        }
    }
}
