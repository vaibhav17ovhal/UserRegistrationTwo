using UserRegistrationTwo;


namespace TestingDetail
{
    [TestClass]
    public class UnitTest1
    {
        private readonly UserRegistrationTwo.Registration obj;

        public UnitTest1()
        {
            obj = new UserRegistrationTwo.Registration();
        }

        [TestMethod]
        [DataRow("Vaibhav", true)]
        [DataRow("a", false)]
        public void Test2(string name, bool value)
        {
            var resultOne = obj.First(name);

            Assert.AreEqual(value, resultOne);
        }

        [TestMethod]
        [DataRow("Ovhal", true)]
        [DataRow("ov", false)]
        public void Test3(string name, bool value)
        {
            var resultTwo = obj.Last(name);

            Assert.AreEqual(value, resultTwo);
        }

        [TestMethod]
        [DataRow("vaibhavovhal15@gmail.com", true)]
        [DataRow("vaibhav@gmail", false)]
        public void Test4(string mail, bool value)
        {
            var resultThree = obj.Email(mail);

            Assert.AreEqual(value, resultThree);
        }

        [TestMethod]
        [DataRow("91 9340596362", true)]
        [DataRow("9340596362", false)]
        public void Test5(string phone, bool value)
        {
            var resultFour = obj.Mobile(phone);

            Assert.AreEqual(value, resultFour);
        }

        [TestMethod]
        [DataRow("V7Ovhal@", true)]
        [DataRow("Vaibhav15", false)]
        public void Test6(string unique , bool value)
        {
            var resultFive = obj.Password(unique);

            Assert.AreEqual(value, resultFive);
        }
    }
}