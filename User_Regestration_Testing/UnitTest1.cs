using User_Registration_Problem_MS_Testing;
namespace User_Regestration_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstName()
        {
            User_Registration user = new User_Registration();
            bool result = user.FirstNameAndLastName("Mahesh");

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestLastName()
        {
            User_Registration user = new User_Registration();
            bool result = user.FirstNameAndLastName("Waghmare");

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestEmail()
        {
            User_Registration user = new User_Registration();
            bool result = user.Email("abc.Mahesh@bl.co.net");

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMobilNumber()
        {
            User_Registration user = new User_Registration();
            bool result = user.MobileNumber("+91 9028876143");

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestPasswordMin8Chrarcters()
        {
            User_Registration user = new User_Registration();
            bool result = user.PassWord("Mahes1245");

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestPasswordMin1UpperCase()
        {
            User_Registration user = new User_Registration();
            bool result = user.PassWord("maheshSw");

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestPasswordMin1Digit()
        {
            User_Registration user = new User_Registration();
            bool result = user.PassWord("maheshS123");

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestPasswordMinSpecialCharacter()
        {
            User_Registration user = new User_Registration();
            bool result = user.PassWord("maheshS@123");

            Assert.IsTrue(result);
        }

    }
}