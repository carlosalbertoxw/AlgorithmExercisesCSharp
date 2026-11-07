namespace AlgorithmExercises.Stacks.BaseballGame;

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
    public int CalPoints(string[] operations)
    {
        var scores = new List<int>();
        foreach (string op in operations)
        {
            switch (op)
            {
                case "+":
                    scores.Add(scores[^1] + scores[^2]);
                    break;
                case "D":
                    scores.Add(scores[^1] * 2);
                    break;
                case "C":
                    scores.RemoveAt(scores.Count - 1);
                    break;
                default:
                    scores.Add(int.Parse(op));
                    break;
            }
        }
        return scores.Sum();
    }
}
