using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.Core.Arrays_and_Hashing
{
    public class TwoSum
    {
        public int[] Solution(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int sum = numbers[left] + numbers[right];

                if (sum == target)
                {
                    return [left + 1, right + 1];
                }

                if (sum > target)
                {
                    right--;
                }
                else
                    left++;
            }

            return [0, 0];
        }
    }
}
