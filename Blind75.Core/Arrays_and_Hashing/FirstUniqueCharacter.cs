using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.Core.Arrays_and_Hashing
{
    public class FirstUniqueCharacter
    {
        public int Solution(string s)
        {
            Dictionary<char, int> hashTable = s.GroupBy(x => x).ToDictionary(c => c.Key, c => c.Count());
            for (int i = 0; i < s.Length; i++)
            {
                if (hashTable[s[i]] == 1)
                    return i;
            }
            return -1;
        }
    }
}
