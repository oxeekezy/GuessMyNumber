using GuessTheNumber;


namespace Tests
{
    [TestClass]
    public class CorrectlyCompareNumbers
    {
        NumberManager manager;

        [TestMethod]
        public void UserInputEqualGuessed()
        {
            int guessedNumber = 20;
            int userInput = 20;

            manager = new NumberManager(guessedNumber);

            (bool,string) result = manager.TryToGuess(userInput).GetResult();

            bool expectedSuccess = true;
            string expectedText = "Числа равны!";

            Assert.AreEqual(expectedSuccess, result.Item1);
            Assert.AreEqual(expectedText, result.Item2);
        }

        [TestMethod]
        public void UserInputNotEqualGuessed()
        {
            int guessedNumber = 20;
            int userInput = 21;

            manager = new NumberManager(guessedNumber);

            (bool, string) result = manager.TryToGuess(userInput).GetResult();

            bool expectedSuccess = false;
            string expectedText = "Введенное число немного больше!";

            Assert.AreEqual(expectedSuccess, result.Item1);
            Assert.AreEqual(expectedText, result.Item2);
        }
    }
}
