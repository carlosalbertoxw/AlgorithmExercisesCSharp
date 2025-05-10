
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace AlgorithmExercises.Test.TwoSum
{
    public class TwoSumTest
    {
        [Fact]
        public void TwoSum_ReturnsCorrectIndices_WhenSolutionExists()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = new Exercises.TwoSum.Solution().TwoSum(nums, target);

            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void TwoSum_ReturnsCorrectIndices_WhenMultipleSolutionsExist()
        {
            int[] nums = { 3, 2, 4 };
            int target = 6;
            int[] result = new Exercises.TwoSum.Solution().TwoSum(nums, target);

            Assert.Equal(new int[] { 1, 2 }, result);
        }

        [Fact]
        public void TwoSum_ReturnsEmptyArray_WhenNoSolutionExists()
        {
            int[] nums = { 1, 2, 3 };
            int target = 10;
            int[] result = new Exercises.TwoSum.Solution().TwoSum(nums, target);

            Assert.Empty(result);
        }

        [Fact]
        public void TwoSum_WorksWithNegativeNumbers()
        {
            int[] nums = { -3, 4, 3, 90 };
            int target = 0;
            int[] result = new Exercises.TwoSum.Solution().TwoSum(nums, target);

            Assert.Equal(new int[] { 0, 2 }, result);
        }
    }
}
