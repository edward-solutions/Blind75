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
            Dictionary<string, List<string>> hashTable = new Dictionary<string, List<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                char[] chars = strs[i].ToCharArray();
                Array.Sort(chars);
                string key = new string(chars);

                //if key is not in hashtable, add a new instance of the list 
                if (!hashTable.ContainsKey(key))
                {
                    hashTable[key] = new List<string>();
                }

                hashTable[key].Add(strs[i]);
            }

            return hashTable.Values.ToList<IList<string>>();
        }

        public static IList<IList<string>> SolutionChatGpt(string[] strs)
        {
            Dictionary<string, List<string>> hashTable = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                // Count frequency of each character (assume lowercase a-z)
                int[] count = new int[26];
                foreach (char c in str)
                    count[c - 'a']++;

                // Convert count array to a string key
                string key = string.Join("#", count); // "#" avoids ambiguity

                if (!hashTable.ContainsKey(key))
                    hashTable[key] = new List<string>();

                hashTable[key].Add(str);
            }

            return hashTable.Values.ToList<IList<string>>();
        }
    }
}
