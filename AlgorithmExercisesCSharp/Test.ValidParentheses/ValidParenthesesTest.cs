
using Xunit;

namespace AlgorithmExercises.Test.ValidParentheses
{
    public class ValidParenthesesTest
    {
        [Theory]
        [InlineData("[{({}[])}]", true)]   // Caso válido
        [InlineData("()", true)]           // Caso válido simple
        [InlineData("{[()]}", true)]       // Caso válido con diferentes tipos
        [InlineData("{[(])}", false)]      // Caso inválido
        [InlineData("{[}", false)]         // Caso inválido incompleto

        public void IsValid_ShouldReturnExpectedResult(string input, bool expected)
        {
            var validator = new Exercises.ValidParentheses.ValidParentheses();
            bool result = validator.IsValid(input);
            Console.WriteLine($"Input: {input} | Expected: {expected} | Got: {result}");
            Assert.Equal(expected, result);
        }
    }
}
