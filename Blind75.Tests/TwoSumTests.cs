namespace Blind75.Tests
{
    public class TwoSumTests
    {
        [Fact]
        public void Test_ExampleCase()
        {
            // Arrange
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            // Act
            var result = TwoSum.Solution(nums, target);

            // Assert
            Assert.Equal(new int[] { 1, 0 }, result);
            // order may vary depending on your implementation
        }

        [Fact]
        public void Test_WithDuplicates()
        {
            int[] nums = { 3, 3 };
            int target = 6;

            var result = TwoSum.Solution(nums, target);

            Assert.Equal(new int[] { 1, 0 }, result);
        }

        [Fact]
        public void Test_NoSolution()
        {
            int[] nums = { 1, 2, 3 };
            int target = 10;

            var result = TwoSum.Solution(nums, target);

            Assert.Equal(new int[] { 0, 0 }, result);
            // matches your method's fallback
        }
    }
}

