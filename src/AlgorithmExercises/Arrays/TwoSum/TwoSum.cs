namespace AlgorithmExercises.Arrays.TwoSum
{
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
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement))
                {
                    return new int[] { dict[complement], i };
                }
                if (!dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = i;
                }
            }
            return Array.Empty<int>();
        }
    }
}
