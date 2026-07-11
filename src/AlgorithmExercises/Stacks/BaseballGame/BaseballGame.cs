namespace AlgorithmExercises.Stacks.BaseballGame
{
    /// <summary>
    /// LeetCode 682. Baseball Game — https://leetcode.com/problems/baseball-game/
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Calcula la suma de los puntajes tras aplicar las operaciones:
        /// número (anota), "+" (suma de los dos últimos), "D" (doble del último), "C" (cancela el último).
        /// Complejidad: O(n) tiempo, O(n) espacio.
        /// </summary>
        public int CalPoints(string[] ops)
        {
            List<int> points = new List<int>();
            for (int i = 0; i < ops.Length; i++)
            {
                if (ops[i] == "+")
                {
                    points.Add(points[points.Count - 1] + points[points.Count - 2]);
                }
                if (ops[i] == "D")
                {
                    points.Add(points[points.Count - 1] * 2);
                }
                if (ops[i] == "C")
                {
                    points.RemoveAt(points.Count - 1);
                }
                int result;
                if (int.TryParse(ops[i], out result))
                {
                    points.Add(result);
                }
            }
            return points.Sum();
        }
    }
}
