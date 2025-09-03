//https://leetcode.com/problems/two-sum/

//Input: nums = [2, 7, 11, 15], target = 9

//Output: [0, 1]
public static class TwoSum
{
    public static int[] Solution(int[] nums, int target)
    {
        Dictionary<int, int> hashTable = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (hashTable.ContainsKey(complement))
            {
                return [i, hashTable[complement]];
            }
            if (!hashTable.ContainsKey(nums[i]))
            {
                //add to hashtable [nums[i], i]
                hashTable.Add(nums[i], i);
            }
        }
        return [0, 0];
    }
}