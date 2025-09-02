using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Blind75.Tests
{
    public class ContainsDuplicateTests
    {
        [Fact]
        public void ReturnsTrue_WhenArrayHasDuplicates()
        {
            int[] nums = new int[] { 1, 2, 3, 1 };
            Assert.True(Solution.ContainsDuplicate(nums));
        }
        [Fact]
        public void ReturnsTrue_WhenArrayHasDuplicatesTop1()
        {
            int[] nums = new int[] { 1, 2, 3, 1 };
            Assert.True(Solution.ContainsDuplicateTop1(nums));
        }
    }
}
