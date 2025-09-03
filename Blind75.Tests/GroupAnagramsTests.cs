using Blind75.Core.Arrays_and_Hashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.Tests
{
    public class GroupAnagramsTests
    {
        [Fact]
        public void Test_BasicExample()
        {
            string[] input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var result = GroupAnagrams.Solution(input);

            // Flatten result to sets for easier comparison
            var resultSets = result.Select(group => new HashSet<string>(group)).ToList();

            Assert.Contains(new HashSet<string> { "eat", "tea", "ate" }, resultSets, new HashSetComparer());
            Assert.Contains(new HashSet<string> { "tan", "nat" }, resultSets, new HashSetComparer());
            Assert.Contains(new HashSet<string> { "bat" }, resultSets, new HashSetComparer());
        }

        [Fact]
        public void Test_EmptyInput()
        {
            string[] input = new string[] { };
            var result = GroupAnagrams.Solution(input);

            Assert.Empty(result);
        }

        [Fact]
        public void Test_SingleWord()
        {
            string[] input = new string[] { "abc" };
            var result = GroupAnagrams.Solution(input);

            Assert.Single(result);
            Assert.Contains("abc", result[0]);
        }

        [Fact]
        public void Test_NoAnagrams()
        {
            string[] input = new string[] { "a", "b", "c" };
            var result = GroupAnagrams.Solution(input);

            Assert.Equal(3, result.Count);
            Assert.Contains("a", result[0]);
            Assert.Contains("b", result[1]);
            Assert.Contains("c", result[2]);
        }

        // Helper comparer to compare HashSet<string> inside Assert.Contains
        private class HashSetComparer : IEqualityComparer<HashSet<string>>
        {
            public bool Equals(HashSet<string> x, HashSet<string> y)
            {
                return x.SetEquals(y);
            }

            public int GetHashCode(HashSet<string> obj)
            {
                int hash = 0;
                foreach (var item in obj)
                {
                    hash ^= item.GetHashCode();
                }
                return hash;
            }
        }
    }
}
