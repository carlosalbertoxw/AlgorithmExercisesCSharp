namespace AlgorithmExercises.TwoPointers.TwoSumLessThanK;

/// <summary>
/// LeetCode 1099. Two Sum Less Than K — https://leetcode.com/problems/two-sum-less-than-k/
/// Solución con dos punteros sobre una copia ordenada del arreglo.
/// Complejidad: O(n log n) tiempo (por el ordenamiento), O(n) espacio (la copia).
/// </summary>
public class TwoPointersSolution
{
    /// <summary>
    /// Devuelve la suma máxima de dos elementos distintos que sea menor que <paramref name="k"/>,
    /// o -1 si no existe tal par. No modifica el arreglo de entrada.
    /// </summary>
    public int TwoSumLessThanK(int[] nums, int k)
    {
        int[] sorted = [.. nums];
        Array.Sort(sorted);

        int best = -1;
        int left = 0;
        int right = sorted.Length - 1;
        while (left < right)
        {
            int sum = sorted[left] + sorted[right];
            if (sum < k)
            {
                best = Math.Max(best, sum);
                left++;
            }
            else
            {
                right--;
            }
        }
        return best;
    }
}

/// <summary>
/// LeetCode 1099. Two Sum Less Than K — https://leetcode.com/problems/two-sum-less-than-k/
/// Solución de fuerza bruta comparando todos los pares.
/// Complejidad: O(n²) tiempo, O(1) espacio adicional.
/// </summary>
public class BruteForceSolution
{
    /// <summary>
    /// Devuelve la suma máxima de dos elementos distintos que sea menor que <paramref name="k"/>,
    /// o -1 si no existe tal par.
    /// </summary>
    public int TwoSumLessThanK(int[] nums, int k)
    {
        int best = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int sum = nums[i] + nums[j];
                if (sum < k && sum > best)
                {
                    best = sum;
                }
            }
        }
        return best;
    }
}
