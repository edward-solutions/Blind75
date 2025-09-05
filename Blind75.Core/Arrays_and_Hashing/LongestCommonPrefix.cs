//https://leetcode.com/problems/longest-common-prefix/description/

namespace Blind75.Core.Arrays_and_Hashing
{
    public static class LongestCommonPrefix
    {
        public static string Solution(string[] strs)
        {
            string substring = string.Empty;
            Dictionary<string, int> stringFrequency = new Dictionary<string, int>();
            foreach (var word in strs)
            {
                substring = string.Empty;
                for (int i = 0; i < word.Length; i++)
                {
                    substring += word[i];
                    if (!stringFrequency.ContainsKey(substring))
                    {
                        stringFrequency.Add(substring, 1);
                    }
                    else
                    {
                        stringFrequency[substring]++; //add count
                    }
                }
            }

            var common = stringFrequency
                        .Where(x => x.Value == strs.Length) // must appear in all words
                        .OrderByDescending(x => x.Key.Length) // longest first
                        .FirstOrDefault();

            return common.Key ?? string.Empty;
        }
    }
}
