
namespace AlgorithmExercises.Exercises.ValidParentheses
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach(char c in s.ToCharArray()){
                switch (c)
                {
                    case '(': stack.Push(c); break;
                    case '[': stack.Push(c); break;
                    case '{': stack.Push(c); break;
                    case ')': if (stack.Count == 0 || !stack.Peek().Equals('(')) { return false; } else { stack.Pop(); break; }
                    case ']': if (stack.Count == 0 || !stack.Peek().Equals('[')) { return false; } else { stack.Pop(); break; }
                    case '}': if (stack.Count == 0 || !stack.Peek().Equals('{')) { return false; } else { stack.Pop(); break; }
                }
            }
            return true;
        }
    }
}
