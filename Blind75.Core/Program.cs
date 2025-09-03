using Blind75.Core.Arrays_and_Hashing;
using Blind75.Core.Two_Pointers;
using System;

public static class Program
{
    public static void Main(string[] args)
    {
        //ValidAnagram.Solution("anagram1", "nagarams");
        //TwoSum.Solution(new int[] { 3,2,4 }, 6);
        //GroupAnagrams.Solution(["eat", "tea", "tan", "ate", "nat", "bat"]);
        //ValidPalindrome.Solution("A man, a plan, a canal: Panama");
        //ValidPalindrome.Solution("A man, a plan, a canal: Panam123a");
        int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        Console.WriteLine(MaximumSubarray.Solution(nums));
    }
}
