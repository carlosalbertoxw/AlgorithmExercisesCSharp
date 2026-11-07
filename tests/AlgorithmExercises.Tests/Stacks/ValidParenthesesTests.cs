using AlgorithmExercises.Stacks.ValidParentheses;

namespace AlgorithmExercises.Tests.Stacks;

public class ValidParenthesesTests
{
    [Theory]
    [InlineData("[{({}[])}]", true)]   // anidado con todos los tipos
    [InlineData("()", true)]           // caso simple
    [InlineData("{[()]}", true)]       // diferentes tipos
    [InlineData("", true)]             // cadena vacía
    [InlineData("(a + b) * [c]", true)] // se ignoran los caracteres que no son brackets
    [InlineData("{[(])}", false)]      // cierre en orden incorrecto
    [InlineData("{[}", false)]         // incompleto
    [InlineData("(", false)]           // apertura sin cerrar
    [InlineData("}", false)]           // cierre sin apertura
    public void IsValid_ReturnsExpectedResult(string input, bool expected)
    {
        Assert.Equal(expected, new Solution().IsValid(input));
    }
}
