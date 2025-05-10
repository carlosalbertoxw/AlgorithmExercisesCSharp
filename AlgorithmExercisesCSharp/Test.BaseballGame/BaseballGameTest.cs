
using Xunit;

namespace AlgorithmExercises.Test.BaseballGame
{
    public class BaseballGameTest
    {
        [Fact]
        public void Test_AllNumbers()
        {
            var game = new Exercises.BaseballGame.BaseballGame();
            string[] ops = { "5", "2", "3" };
            int result = game.CalPoints(ops);
            Assert.Equal(10, result); // 5 + 2 + 3
        }

        [Fact]
        public void Test_WithAddition()
        {
            var game = new Exercises.BaseballGame.BaseballGame();
            string[] ops = { "5", "-2", "4", "+", "3" };
            int result = game.CalPoints(ops);
            Assert.Equal(12, result); // 5, -2, 4, (4 + -2 = 2), 3 → sum = 12
        }

        [Fact]
        public void Test_WithDouble()
        {
            var game = new Exercises.BaseballGame.BaseballGame();
            string[] ops = { "5", "D" };
            int result = game.CalPoints(ops);
            Assert.Equal(15, result); // 5, 10 → sum = 15
        }

        [Fact]
        public void Test_WithCancel()
        {
            var game = new Exercises.BaseballGame.BaseballGame();
            string[] ops = { "5", "2", "C" };
            int result = game.CalPoints(ops);
            Assert.Equal(5, result); // 5, 2 (then remove 2) → 5
        }

        [Fact]
        public void Test_MixedOperations()
        {
            var game = new Exercises.BaseballGame.BaseballGame();
            string[] ops = { "5", "-2", "4", "C", "D", "9", "+", "+" };
            int result = game.CalPoints(ops);
            Assert.Equal(27, result);
            // Steps:
            // 5, -2, 4 → C removes 4
            // D = -4, 9, + = -4 + 9 = 5, + = 9 + 5 = 14
            // Final = 5 -2 -4 9 5 14 = 27
        }

        [Fact]
        public void Test_EmptyInput()
        {
            var game = new Exercises.BaseballGame.BaseballGame();
            string[] ops = { };
            int result = game.CalPoints(ops);
            Assert.Equal(0, result);
        }
    }
}
