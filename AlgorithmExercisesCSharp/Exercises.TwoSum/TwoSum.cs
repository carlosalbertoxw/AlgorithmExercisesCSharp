/*
 * URL Problem: https://leetcode.com/problems/two-sum/
 */
namespace AlgorithmExercises.Exercises.TwoSum
{
    public class Solution
    {
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
            return new int[] { };
        }
    }
}
