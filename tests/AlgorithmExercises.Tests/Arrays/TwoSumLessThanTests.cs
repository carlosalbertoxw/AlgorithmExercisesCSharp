using AlgorithmExercises.Arrays.TwoSumLessThan;
using Xunit;

namespace AlgorithmExercises.Tests.Arrays
{
    public class TwoSumLessThanTests
    {
        [Theory]
        [InlineData(new int[] { 34, 23, 1, 24, 75, 33, 54, 8 }, 60, 58)]
        [InlineData(new int[] { 10, 20, 30 }, 15, -1)]
        [InlineData(new int[] { 99, 1 }, 100, -1)] // 99 + 1
        [InlineData(new int[] { 1, 1, 1, 1 }, 3, 2)]
        [InlineData(new int[] { 100, 101 }, 50, -1)]
        public void Test_BruteForce_ValidCases(int[] A, int K, int expected)
        {
            int result = BruteForceSolution.TwoSumLessThan(A, K);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 34, 23, 1, 24, 75, 33, 54, 8 }, 60, 58)]
        [InlineData(new int[] { 10, 20, 30 }, 15, -1)]
        [InlineData(new int[] { 99, 1 }, 100, -1)] // 99 + 1
        [InlineData(new int[] { 1, 1, 1, 1 }, 3, 2)]
        [InlineData(new int[] { 100, 101 }, 50, -1)]
        public void Test_TwoPointers_ValidCases(int[] A, int K, int expected)
        {
            int result = TwoPointersSolution.TwoSumLessThan(A, K);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_BruteForce_InvalidLength()
        {
            int[] A = new int[0];
            int result = BruteForceSolution.TwoSumLessThan(A, 10);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Test_TwoPointers_InvalidLength()
        {
            int[] A = new int[101];
            int result = TwoPointersSolution.TwoSumLessThan(A, 10);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Test_BruteForce_InvalidValues()
        {
            int[] A = new int[] { 5, 300 }; // 300 is out of range
            int result = BruteForceSolution.TwoSumLessThan(A, 1000);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Test_TwoPointers_InvalidValues()
        {
            int[] A = new int[] { 0, 5 }; // 0 is out of valid range
            int result = TwoPointersSolution.TwoSumLessThan(A, 100);
            Assert.Equal(-1, result);
        }
    }
}
