using AlgorithmExercises.TwoPointers.TwoSumLessThanK;

namespace AlgorithmExercises.Tests.TwoPointers;

public class TwoSumLessThanKTests
{
    public static TheoryData<int[], int, int> Cases => new()
    {
        { [34, 23, 1, 24, 75, 33, 54, 8], 60, 58 }, // 34 + 24
        { [10, 20, 30], 15, -1 },                  // ningún par suma menos de 15
        { [99, 1], 100, -1 },                      // 99 + 1 = 100 no es menor que 100
        { [1, 1, 1, 1], 3, 2 },                    // valores repetidos
        { [-1, 0, 2, 5, 8], 7, 5 },                // 0 + 5 (con negativos)
        { [5], 10, -1 },                           // un solo elemento
        { [], 10, -1 },                            // arreglo vacío
    };

    [Theory]
    [MemberData(nameof(Cases))]
    public void BruteForce_ReturnsMaxSumBelowK(int[] nums, int k, int expected)
    {
        Assert.Equal(expected, new BruteForceSolution().TwoSumLessThanK(nums, k));
    }

    [Theory]
    [MemberData(nameof(Cases))]
    public void TwoPointers_ReturnsMaxSumBelowK(int[] nums, int k, int expected)
    {
        Assert.Equal(expected, new TwoPointersSolution().TwoSumLessThanK(nums, k));
    }

    [Fact]
    public void TwoPointers_DoesNotModifyInput()
    {
        int[] nums = [34, 23, 1, 24];

        new TwoPointersSolution().TwoSumLessThanK(nums, 60);

        Assert.Equal([34, 23, 1, 24], nums);
    }
}
