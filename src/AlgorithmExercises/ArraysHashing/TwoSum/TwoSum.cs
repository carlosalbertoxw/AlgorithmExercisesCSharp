namespace AlgorithmExercises.ArraysHashing.TwoSum;

/// <summary>
/// LeetCode 1. Two Sum — https://leetcode.com/problems/two-sum/
/// </summary>
public class Solution
{
    /// <summary>
    /// Devuelve los índices de los dos números que suman <paramref name="target"/>,
    /// o un arreglo vacío si no existe solución.
    /// Complejidad: O(n) tiempo, O(n) espacio (una sola pasada con diccionario).
    /// </summary>
    public int[] TwoSum(int[] nums, int target)
    {
        var seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (seen.TryGetValue(target - nums[i], out int complementIndex))
            {
                return [complementIndex, i];
            }
            seen.TryAdd(nums[i], i);
        }
        return [];
    }
}
