using GuessTheNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class ReturnCorrectlyText
    {
        NumberManager manager;

        [TestMethod]
        public void UserInputFewLessGuessed() 
        {
            int guessedNumber = 200;
            int userInput = 198;

            manager = new NumberManager(guessedNumber);

            (bool, string) result = manager.TryToGuess(userInput).GetResult();

            string expectedText = "Введенное число немного меньше!";

            Assert.AreEqual(expectedText, result.Item2);
        }

        [TestMethod]
        public void UserInputLessGuessed()
        {
            int guessedNumber = 200;
            int userInput = 100;

            manager = new NumberManager(guessedNumber);

            (bool, string) result = manager.TryToGuess(userInput).GetResult();

            string expectedText = "Введенное число меньше!";

            Assert.AreEqual(expectedText, result.Item2);
        }

        [TestMethod]
        public void UserInputMostLessGuessed()
        {
            int guessedNumber = 200;
            int userInput = 19;

            manager = new NumberManager(guessedNumber);

            (bool, string) result = manager.TryToGuess(userInput).GetResult();
            string expectedText = "Введенное число много меньше!";

            Assert.AreEqual(expectedText, result.Item2);
        }

        [TestMethod]
        public void UserInputFewOverGuessed()
        {
            int guessedNumber = 200;
            int userInput = 201;

            manager = new NumberManager(guessedNumber);

            (bool, string) result = manager.TryToGuess(userInput).GetResult();

            string expectedText = "Введенное число немного больше!";

            Assert.AreEqual(expectedText, result.Item2);
        }

        [TestMethod]
        public void UserInputOverGuessed()
        {
            int guessedNumber = 200;
            int userInput = 400;

            manager = new NumberManager(guessedNumber);

            (bool, string) result = manager.TryToGuess(userInput).GetResult();

            string expectedText = "Введенное число больше!";

            Assert.AreEqual(expectedText, result.Item2);
        }

        [TestMethod]
        public void UserInputMostOverGuessed()
        {
            int guessedNumber = 200;
            int userInput = 2000;

            manager = new NumberManager(guessedNumber);

            (bool, string) result = manager.TryToGuess(userInput).GetResult();

            string expectedText = "Введенное число много больше!";

            Assert.AreEqual(expectedText, result.Item2);
        }

        [TestMethod]
        public void UserInputEqualGuessed()
        {
            int guessedNumber = 200;
            int userInput = 200;

            manager = new NumberManager(guessedNumber);

            (bool, string) result = manager.TryToGuess(userInput).GetResult();

            string expectedText = "Числа равны!";

            Assert.AreEqual(expectedText, result.Item2);
        }
    }
}
