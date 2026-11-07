using AlgorithmExercises.Stacks.BaseballGame;

namespace AlgorithmExercises.Tests.Stacks;

public class BaseballGameTests
{
    [Theory]
    [InlineData(new[] { "5", "2", "3" }, 10)]                          // 5 + 2 + 3
    [InlineData(new[] { "5", "-2", "4", "+", "3" }, 12)]               // 5, -2, 4, 2, 3
    [InlineData(new[] { "5", "D" }, 15)]                               // 5, 10
    [InlineData(new[] { "5", "2", "C" }, 5)]                           // 5 (se cancela el 2)
    [InlineData(new[] { "5", "-2", "4", "C", "D", "9", "+", "+" }, 27)] // 5, -2, -4, 9, 5, 14
    [InlineData(new string[0], 0)]                                     // sin operaciones
    public void CalPoints_ReturnsSumOfScores(string[] operations, int expected)
    {
        Assert.Equal(expected, new Solution().CalPoints(operations));
    }
}
