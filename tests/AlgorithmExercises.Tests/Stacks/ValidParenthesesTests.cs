using AlgorithmExercises.Stacks.ValidParentheses;
using Xunit;

namespace AlgorithmExercises.Tests.Stacks
{
    public class ValidParenthesesTests
    {
        [Theory]
        [InlineData("[{({}[])}]", true)]   // Caso válido
        [InlineData("()", true)]           // Caso válido simple
        [InlineData("{[()]}", true)]       // Caso válido con diferentes tipos
        [InlineData("{[(])}", false)]      // Caso inválido
        [InlineData("{[}", false)]         // Caso inválido incompleto
        [InlineData("(", false)]           // Apertura sin cerrar
        [InlineData("", true)]             // Cadena vacía es válida
        public void IsValid_ShouldReturnExpectedResult(string input, bool expected)
        {
            var validator = new Solution();
            bool result = validator.IsValid(input);
            Assert.Equal(expected, result);
        }
    }
}
