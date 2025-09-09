using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.Core.Strings
{
    public static class GetLucky
    {
        public static int Solution(string s, int k)
        {
            //zbax = 26 2 1 24, k = 2

            string stringToNumber = string.Empty;
            int result = 0;

            //convert to numbers
            foreach (char c in s)
            {
                stringToNumber += (c - 'a' + 1).ToString();
            }

            char[] charArray = stringToNumber.ToCharArray();

            //loop until k
            for (int i = 0; i < k; i++)
            {
                result = 0;
                //loop until string length
                for (int j = 0; j < charArray.Length; j++)
                {
                    result += charArray[j] - '0';
                }
                charArray = result.ToString().ToCharArray();
            }

            return result;

        }
    }
}
