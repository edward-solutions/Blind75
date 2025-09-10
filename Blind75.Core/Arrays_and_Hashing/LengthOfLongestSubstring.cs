using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.Core.Arrays_and_Hashing
{
    public static class LengthOfLongestSubstring
    {
        public static int Solution(string s)
        {
            int left = 0, maxCount = 0;
            HashSet<char> chars = new HashSet<char>();

            for (int right = 0; right < s.Length; right++)
            {
                while (chars.Contains(s[right]))
                {
                    chars.Remove(s[left]);
                    left++;
                }
                chars.Add(s[right]);
                maxCount = Math.Max(maxCount, right - left + 1);
            }

            return maxCount;
        }
    }

}
