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
    }
}