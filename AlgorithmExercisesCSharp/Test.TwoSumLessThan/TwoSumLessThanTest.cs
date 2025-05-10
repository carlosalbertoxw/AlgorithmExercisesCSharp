
using AlgorithmExercises.Exercises.TwoSumLessThan;
using Xunit;

namespace AlgorithmExercises.Test.TwoSumLessThan
{
    public class TwoSumLessThanTest
    {
        [Theory]
        [InlineData(new int[] { 34, 23, 1, 24, 75, 33, 54, 8 }, 60, 58)]
        [InlineData(new int[] { 10, 20, 30 }, 15, -1)]
        [InlineData(new int[] { 99, 1 }, 100, -1)] // 99 + 1
        [InlineData(new int[] { 1, 1, 1, 1 }, 3, 2)]
        [InlineData(new int[] { 100, 101 }, 50, -1)]
        public void Test_Solution1_ValidCases(int[] A, int K, int expected)
        {
            int result = Solution1.TwoSumLessThan(A, K);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 34, 23, 1, 24, 75, 33, 54, 8 }, 60, 58)]
        [InlineData(new int[] { 10, 20, 30 }, 15, -1)]
        [InlineData(new int[] { 99, 1 }, 100, -1)] // 99 + 1
        [InlineData(new int[] { 1, 1, 1, 1 }, 3, 2)]
        [InlineData(new int[] { 100, 101 }, 50, -1)]
        public void Test_Solution2_ValidCases(int[] A, int K, int expected)
        {
            int result = Solution2.TwoSumLessThan(A, K);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Solution1_InvalidLength()
        {
            int[] A = new int[0];
            int result = Solution1.TwoSumLessThan(A, 10);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Test_Solution2_InvalidLength()
        {
            int[] A = new int[101];
            int result = Solution2.TwoSumLessThan(A, 10);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Test_Solution1_InvalidValues()
        {
            int[] A = new int[] { 5, 300 }; // 300 is out of range
            int result = Solution1.TwoSumLessThan(A, 1000);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Test_Solution2_InvalidValues()
        {
            int[] A = new int[] { 0, 5 }; // 0 is out of valid range
            int result = Solution2.TwoSumLessThan(A, 100);
            Assert.Equal(-1, result);
        }
    }
}
