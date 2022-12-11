using GuessTheNumber;

namespace Tests
{
    [TestClass]
    public class ClassIsNotNull
    {
        [TestMethod]
        public void CreateInstance()
        {
            Assert.IsNotNull(new NumberManager(1));
        }
    }
}