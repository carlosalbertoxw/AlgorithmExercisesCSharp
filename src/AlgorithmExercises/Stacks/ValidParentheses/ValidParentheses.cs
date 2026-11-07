namespace AlgorithmExercises.Stacks.ValidParentheses;

/// <summary>
/// LeetCode 20. Valid Parentheses — https://leetcode.com/problems/valid-parentheses/
/// </summary>
public class Solution
{
    // Cada símbolo de cierre mapea al de apertura que le corresponde.
    private static readonly Dictionary<char, char> Pairs = new()
    {
        [')'] = '(',
        [']'] = '[',
        ['}'] = '{',
    };

    /// <summary>
    /// Determina si la cadena de paréntesis, corchetes y llaves está balanceada.
    /// Los caracteres que no son brackets se ignoran.
    /// Complejidad: O(n) tiempo, O(n) espacio (pila de aperturas pendientes).
    /// </summary>
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        foreach (char c in s)
        {
            if (c is '(' or '[' or '{')
            {
                stack.Push(c);
            }
            else if (Pairs.TryGetValue(c, out char opening)
                     && (!stack.TryPop(out char top) || top != opening))
            {
                return false;
            }
        }
        return stack.Count == 0;
    }
}
