public static class TwoSum
{
    public static int[] Solution(int[] nums, int target)
    {
        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (keyValuePairs.ContainsKey(complement)) return [i, keyValuePairs[complement]];
            if (!keyValuePairs.ContainsKey(nums[i])) keyValuePairs.Add(nums[i], i);
        }
        return [0, 0];
    }
}