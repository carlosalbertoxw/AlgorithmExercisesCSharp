namespace AlgorithmExercises.Stacks.ValidParentheses
{
    /// <summary>
    /// LeetCode 20. Valid Parentheses — https://leetcode.com/problems/valid-parentheses/
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Determina si la cadena de paréntesis, corchetes y llaves está balanceada.
        /// Complejidad: O(n) tiempo, O(n) espacio (pila de aperturas pendientes).
        /// </summary>
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                switch (c)
                {
                    case '(': stack.Push(c); break;
                    case '[': stack.Push(c); break;
                    case '{': stack.Push(c); break;
                    case ')': if (stack.Count == 0 || stack.Peek() != '(') { return false; } else { stack.Pop(); break; }
                    case ']': if (stack.Count == 0 || stack.Peek() != '[') { return false; } else { stack.Pop(); break; }
                    case '}': if (stack.Count == 0 || stack.Peek() != '{') { return false; } else { stack.Pop(); break; }
                }
            }
            return stack.Count == 0;
        }
    }
}
