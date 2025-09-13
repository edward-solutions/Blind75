using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.Core.Arrays_and_Hashing
{
    public class ReversePrefix
    {
        public string Solution(string word, char ch)
        {
            int left = 0;
            int right = 0;
            //a b c 3
            while (word[right] != ch)
            {
                right++;
                if (right > word.Length - 1) return word;
            }

            char[] result = word.ToCharArray();

            while (left < right)
            {
                char temp = result[left];
                result[left] = result[right];
                result[right] = temp;
                left++;
                right--;
            }

            return new string(result);
        }
    }
}
