using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Blind75.Tests
{
    public class ValidAnagramsTests
    {
       

        [Fact]
        public void ReturnsTrue_WhenArrayHasDuplicates()
        {
            string s = "anagram";
            string t = "nagaram";
            Assert.True(ValidAnagram.Solution(s,t));
        }
        [Fact]
        public void ReturnsTrue_WhenArrayHasDuplicatesTop1()
        {
            string s = "anagram";
            string t = "nagaram";
            Assert.True(ValidAnagram.Solution_Leetcode(s,t));
        }
    }
}
