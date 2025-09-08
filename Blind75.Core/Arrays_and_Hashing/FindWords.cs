using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.Core.Arrays_and_Hashing
{
    public class FindWords
    {
        public string[] Solution(string[] words)
        {
            var list = new List<string>();

            var map = new Dictionary<char, int>
            {
                ['q'] = 1,
                ['w'] = 1,
                ['e'] = 1,
                ['r'] = 1,
                ['t'] = 1,
                ['y'] = 1,
                ['u'] = 1,
                ['i'] = 1,
                ['o'] = 1,
                ['p'] = 1,

                ['a'] = 2,
                ['s'] = 2,
                ['d'] = 2,
                ['f'] = 2,
                ['g'] = 2,
                ['h'] = 2,
                ['j'] = 2,
                ['k'] = 2,
                ['l'] = 2,

                ['z'] = 3,
                ['x'] = 3,
                ['c'] = 3,
                ['v'] = 3,
                ['b'] = 3,
                ['n'] = 3,
                ['m'] = 3,
            };

            foreach (string word in words)
            {
                int row = map[char.ToLower(word[0])];
                bool valid = true;

                for (int i = 1; i < word.Length; i++)
                {
                    if (map[char.ToLower(word[i])] != row)
                    {
                        valid = false;
                        break;
                    }
                }

                if (valid)
                    list.Add(word);
            }

            return list.ToArray();
        }
    }

}
