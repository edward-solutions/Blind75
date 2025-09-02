//https://leetcode.com/problems/group-anagrams/description/

//Input: strs = ["eat", "tea", "tan", "ate", "nat", "bat"]

//Output: [["bat"],["nat", "tan"],["ate", "eat", "tea"]]

using System.Diagnostics.Tracing;

namespace Blind75.Core.Arrays_and_Hashing
{
    public static class GroupAnagrams
    {
        public static IList<IList<string>> Solution(string[] strs)
        {
            //edge cases
            if (strs.Length == 0) return new List<IList<string>>();
            if (strs.Length == 1) return new List<IList<string>> { new List<string> { strs[0] } };

            Dictionary<string, List<string>> hashTable = new Dictionary<string, List<string>>();

            foreach (var word in strs)
            {
                char[] chars = word.ToCharArray();
                Array.Sort(chars);
                string key = new string(chars);
                if (!hashTable.ContainsKey(key))
                {
                    hashTable[key] = new List<string>();
                }
                hashTable[key].Add(word);
            }

            return hashTable.Values.ToList<IList<string>>();
        }
    }
}
