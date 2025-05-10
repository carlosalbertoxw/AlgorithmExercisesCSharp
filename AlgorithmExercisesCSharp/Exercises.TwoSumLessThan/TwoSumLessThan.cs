/*
    URL Problem: https://leetcode.com/problems/two-sum-less-than-k/
*/
namespace AlgorithmExercises.Exercises.TwoSumLessThan
{
    public class Solution2
    {
        public static int TwoSumLessThan(int[] A, int K)
        {
            if (A.Length < 1 || A.Length > 100 || K < 1 || K > 2000)
            {
                return -1;
            }
            int S = -1;
            Array.Sort(A);
            int l = 0;
            int r = A.Length - 1;
            while (l < r)
            {
                if (A[l] < 1 || A[l] > 200 || A[r] < 1 || A[r] > 200)
                {
                    return -1;
                }
                int sum = A[l] + A[r];
                if (sum < K)
                {
                    S = Math.Max(S, sum);
                    l++;
                }
                else
                {
                    r--;
                }
            }
            return S;
        }
    }
    public class Solution1
    {
        public static int TwoSumLessThan(int[] A, int K)
        {
            if (A.Length < 1 || A.Length > 100 || K < 1 || K > 2000)
            {
                return -1;
            }
            int S = -1;
            for (int i = 0; i < A.Length; i++)
            {
                for (int y = 0; y < A.Length; y++)
                {
                    if (A[i] < 1 || A[i] > 200 || A[y] < 1 || A[y] > 200)
                    {
                        return -1;
                    }
                    int sum = A[i] + A[y];
                    if (i != y && sum < K && sum > S)
                    {
                        S = A[i] + A[y];
                    }
                }
            }
            return S;
        }
    }
    
}
