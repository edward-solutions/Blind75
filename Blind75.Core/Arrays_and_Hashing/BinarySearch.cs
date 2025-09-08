using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.Core.Arrays_and_Hashing
{
    public static class BinarySearch
    {
        //[1,2,3,4,5] target = 4
        public static int Solution(int[] nums, int target)
        {
            int lo = 0;
            int hi = nums.Length - 1;

            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;

                if (nums[mid] == target)
                    return mid;

                if (nums[mid] > target)
                    hi = mid - 1;
                else
                    lo = mid + 1;
            }

            return -1;
        }
    }
}
