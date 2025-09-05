//https://leetcode.com/problems/majority-element/

public static class MajorityElement
{
    public static int Solution(int[] nums)
    {
        var map = nums.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        return map.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
    }
}