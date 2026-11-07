using AlgorithmExercises.ArraysHashing.TwoSum;

namespace AlgorithmExercises.Tests.ArraysHashing;

public class TwoSumTests
{
    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]   // caso básico
    [InlineData(new[] { -3, 4, 3, 90 }, 0, new[] { 0, 2 })]   // números negativos
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]        // no usa el mismo elemento dos veces (3 + 3)
    [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]           // valores repetidos
    public void TwoSum_ReturnsIndices_WhenSolutionExists(int[] nums, int target, int[] expected)
    {
        Assert.Equal(expected, new Solution().TwoSum(nums, target));
    }

    [Fact]
    public void TwoSum_ReturnsEmpty_WhenNoSolutionExists()
    {
        Assert.Empty(new Solution().TwoSum([1, 2, 3], 10));
    }
}
