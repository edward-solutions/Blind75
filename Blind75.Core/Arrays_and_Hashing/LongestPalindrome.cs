//https://leetcode.com/problems/longest-palindrome/submissions/1760095298/
public class LongestPalindrome
{
    public int Solution(string s)
    {
        Dictionary<char, int> map = s.GroupBy(c => c).ToDictionary(x => x.Key, x => x.Count());

        int length = 0;
        bool hasOdd = false;

        foreach (KeyValuePair<char, int> kvp in map)
        {
            int count = kvp.Value;
            length += (count / 2) * 2;
            if (count % 2 != 0) hasOdd = true;
        }

        if (hasOdd) length++;

        return length;
    }
}