//https://leetcode.com/problems/plus-one/

//[8,9,9,9]
//[9,0,0,0]

namespace Blind75.Core.Arrays_and_Hashing
{
    public static class PlusOne
    {
        public static int[] Solution(int[] digits)
        {
            for(int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }

            int[] arr = new int[digits.Length + 1];
            arr[0] = 1;
            return arr;
        }
    }
}
