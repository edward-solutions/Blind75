﻿//Title: Contains Duplicate
//Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
//Input: nums = [1, 2, 3, 1]
//Output: true
//Explanation:
//The element 1 occurs at the indices 0 and 3.
//Example 2:
//Input: nums = [1, 2, 3, 4]
//Output: false
//Explanation:
//All elements are distinct.
//Example 3:
//Input: nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2]
//Output: true
//Constraints:
//1 <= nums.length <= 105
//- 109 <= nums[i] <= 109

int[] nums = new int[] { 1, 2, 3, 1 };

Solution.ContainsDuplicate(nums);

public static class Solution
{
    public static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> ints = new HashSet<int>();
        foreach(int num in nums)
        {
            ints.Add(num);
        }
        return nums.Length != ints.Count;
    }
}

//Top1
//public class Solution
//{
//    public bool ContainsDuplicate(int[] nums)
//    {
//        return new HashSet<int>(nums).Count < nums.Length;
//    }
//}