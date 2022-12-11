using Microsoft.VisualStudio.TestTools.UnitTesting;
using User_Registration_Problem_MS_Testing;
namespace User_Regestration_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Mah", true)]
        [DataRow("Ma", false)]
        [DataRow("Mahesh", true)]
        [DataRow("Mahi12", false)]
        public void TestFirstName(string firstName, bool expected)
        {
            User_Registration user = new User_Registration();
            bool actual = user.FirstNameAndLastName(firstName);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("Wagh", true)]
        [DataRow("Wa", false)]
        [DataRow("Waghmare", true)]
        [DataRow("Wagh12", false)]
        public void TestLastName(string lastName, bool expected)
        {
            User_Registration user = new User_Registration();
            bool actual = user.FirstNameAndLastName(lastName);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("abc.Mahesh@bl.co.net", true)]
        [DataRow("abcMahesh@bl.co.net", true)]
        [DataRow("abc_Mahesh@bl.co.net", true)]
        [DataRow("abc+Mahesh@bl.co.net", true)]
        [DataRow("abc-Mahesh@bl.co.net", true)]
        [DataRow("abc12Mahesh@bl.co.net", true)]
        [DataRow("ab12Mahesh@bl.co.net", false)]
        [DataRow("abc12Mahesh@bl.co.in", false)]
        [DataRow("abc12Mahesh@blc.co.net", false)]
        [DataRow("abc12Mahesh@bl.com.net", false)]
        [DataRow("abc12Maheshbl.co.net", false)]
        public void TestEmail(string email, bool expected)
        {
            User_Registration user = new User_Registration();
            bool actual = user.Email(email);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("+1 1000987267", true)]
        [DataRow("+91 9842905050", true)]
        [DataRow("+111 9842905050", true)]
        [DataRow("+919842905050", false)]
        [DataRow("+919842905", false)]
        [DataRow("+91 984290", false)]
        [DataRow("+91 984290505000000", false)]
        [DataRow("91 9842905050", false)]
        public void TestMobilNumber(string mobileNumber, bool expected)
        {
            User_Registration user = new User_Registration();
            bool actual = user.MobileNumber(mobileNumber);

            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        [DataRow("Mahesh@123", true)]
        [DataRow("maHe#sh123", true)]
        [DataRow("mahe@sh1S", true)]
        [DataRow("@Mahesh129", true)]
        [DataRow("Ma-hesh123", true)]
        [DataRow("mahesh123)@1234", false)]
        [DataRow("Mahe@shw", false)]
        [DataRow("mah123", false)]
        [DataRow("mah@123", false)]
        [DataRow("@Mah#12esh", true)]
        [DataRow(")Mahe12", false)]
        [DataRow(")maHe12", false)]
        [DataRow("mah-esh@12S", true)]
        [DataRow("maheShw@s", false)]
        public void TestPassword(string password, bool expected)
        {
            User_Registration user = new User_Registration();
            bool actual = user.PassWord(password);

            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        [DataRow("abc@yahoo.com,", true)]
        [DataRow("abc-100@yahoo.com,", true)]
        [DataRow("abc.100@yahoo.com", true)]
        [DataRow("abc111@abc.com,", true)]
        [DataRow("abc-100@abc.net,", true)]
        [DataRow("abc.100@abc.com.au", true)]
        [DataRow("abc@1.com,", true)]
        [DataRow("abc@gmail.com.com", true)]
        [DataRow("abc+100@gmail.com", true)]
        [DataRow("abc", false)]
        [DataRow("abc@.com.my", false)]
        [DataRow("abc123@gmail.a", false)]
        [DataRow("abc123@.com", false)]
        [DataRow("abc123@.com.com", false)]
        [DataRow(".abc@abc.com", false)]
        [DataRow("abc()*@gmail.com", false)]
        [DataRow("abc..2002@gmail.com", false)]
        [DataRow("abc.@gmail.com", false)]
        [DataRow("abc@abc@gmail.com", false)]
        [DataRow("abc@gmail.com.1a", false)]
        [DataRow("abc@gmail.com.aa.au", false)]
        [DataRow("abc@%*.com", false)]

        public void TestSampleEmails(string email, bool expected)
        {
            User_Registration user = new User_Registration();
            bool actual = user.SampleEmail(email);

            Assert.AreEqual(expected,actual);
        }

    }
}