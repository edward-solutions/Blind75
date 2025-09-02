// Title: Valid Anagram
//
// Given two strings s and t, return true if t is an anagram of s, 
// and false otherwise.
//
// Example 1:
// Input:  s = "anagram", t = "nagaram"
// Output: true
//
// Example 2:
// Input:  s = "rat", t = "car"
// Output: false
//
// Constraints:
// 1 <= s.length, t.length <= 5 * 10^4
// s and t consist of lowercase English letters.

public static class ValidAnagram
{
    public static bool Solution(string s, string t)
    {
        Dictionary<char, int> sDictionary = s.GroupBy(c => c).ToDictionary(x => x.Key, x => x.Count());
        Dictionary<char, int> tDictionary = t.GroupBy(c => c).ToDictionary(x => x.Key, x => x.Count());

        if (sDictionary.Keys.Count != tDictionary.Keys.Count) return false;

        foreach (KeyValuePair<char, int> kv in sDictionary)
        {
            if (!tDictionary.ContainsKey(kv.Key) || tDictionary[kv.Key] != kv.Value) return false;
        }

        return true;
    }

    public static bool Solution_Leetcode(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> freqs = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (!freqs.ContainsKey(c))
            {
                freqs[c] = 0;
            }
            freqs[c]++;
        }

        int lettersToSatisfy = freqs.Count;
        foreach (char c in t)
        {
            if (!freqs.ContainsKey(c))
            {
                return false;
            }
            freqs[c]--;
            if (freqs[c] < 0)
            {
                return false;
            }
            if (freqs[c] == 0)
            {
                lettersToSatisfy--;
            }
        }

        return lettersToSatisfy == 0;
    }
}