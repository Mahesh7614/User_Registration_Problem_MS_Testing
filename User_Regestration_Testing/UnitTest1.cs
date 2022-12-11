using Microsoft.VisualStudio.TestTools.UnitTesting;
using User_Registration_Problem_MS_Testing;
namespace User_Regestration_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(null, "Name Should Not be Null")]
        [DataRow("", "Name Should Not be Empty")]
        [DataRow("Mah", "True")]
        [DataRow("Ma", "Please enter a Valid Name!")]
        [DataRow("Mahesh", "True")]
        [DataRow("Mahi12", "Please enter a Valid Name!")]
        public void TestFirstName(string firstName, string expected)
        {
            User_Registration user = new User_Registration();
            string actual = user.FirstNameAndLastName(firstName);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(null, "Name Should Not be Null")]
        [DataRow("", "Name Should Not be Empty")]
        [DataRow("Wagh", "True")]
        [DataRow("Wa", "Please enter a Valid Name!")]
        [DataRow("Waghmare", "True")]
        [DataRow("Wagh12", "Please enter a Valid Name!")]
        public void TestLastName(string lastName, string expected)
        {
            User_Registration user = new User_Registration();
            string actual = user.FirstNameAndLastName(lastName);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(null, "Email Should Not be Null")]
        [DataRow("", "Email Should Not be Empty")]
        [DataRow("abc.Mahesh@bl.co.net", "True")]
        [DataRow("abcMahesh@bl.co.net", "True")]
        [DataRow("abc_Mahesh@bl.co.net", "True")]
        [DataRow("abc+Mahesh@bl.co.net", "True")]
        [DataRow("abc-Mahesh@bl.co.net", "True")]
        [DataRow("abc12Mahesh@bl.co.net", "True")]
        [DataRow("ab12Mahesh@bl.co.net", "Please enter a Valid Email!")]
        [DataRow("abc12Mahesh@bl.co.in", "Please enter a Valid Email!")]
        [DataRow("abc12Mahesh@blc.co.net", "Please enter a Valid Email!")]
        [DataRow("abc12Mahesh@bl.com.net", "Please enter a Valid Email!")]
        [DataRow("abc12Maheshbl.co.net", "Please enter a Valid Email!")]
        public void TestEmail(string email, string expected)
        {
            User_Registration user = new User_Registration();
            string actual = user.Email(email);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(null, "Mobile Number Should Not be Null")]
        [DataRow("", "Mobile Number Should Not be Empty")]
        [DataRow("+1 1000987267", "True")]
        [DataRow("+91 9842905050", "True")]
        [DataRow("+111 9842905050", "True")]
        [DataRow("+919842905050", "Please enter a Valid Mobile Number!")]
        [DataRow("+919842905", "Please enter a Valid Mobile Number!")]
        [DataRow("+91 984290", "Please enter a Valid Mobile Number!")]
        [DataRow("+91 984290505000000", "Please enter a Valid Mobile Number!")]
        [DataRow("91 9842905050", "Please enter a Valid Mobile Number!")]
        public void TestMobilNumber(string mobileNumber, string expected)
        {
            User_Registration user = new User_Registration();
            string actual = user.MobileNumber(mobileNumber);

            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        [DataRow(null, "Password Should Not be Null")]
        [DataRow("", "Password Should Not be Empty")]
        [DataRow("Mahesh@123", "True")]
        [DataRow("maHe#sh123", "True")]
        [DataRow("mahe@sh1S", "True")]
        [DataRow("@Mahesh129", "True")]
        [DataRow("Ma-hesh123", "True")]
        [DataRow("mahesh123)@1234", "Please enter a Valid Password!")]
        [DataRow("Mahe@shw", "Please enter a Valid Password!")]
        [DataRow("mah123", "Please enter a Valid Password!")]
        [DataRow("mah@123", "Please enter a Valid Password!")]
        [DataRow("@Mah#12esh", "True")]
        [DataRow(")Mahe12", "Please enter a Valid Password!")]
        [DataRow(")maHe12", "Please enter a Valid Password!")]
        [DataRow("mah-esh@12S", "True")]
        [DataRow("maheShw@s", "Please enter a Valid Password!")]
        public void TestPassword(string password, string expected)
        {
            User_Registration user = new User_Registration();
            string actual = user.PassWord(password);

            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        [DataRow(null, "EmailID Should Not be Null")]
        [DataRow("", "EmailID Should Not be Empty")]
        [DataRow("abc@yahoo.com,", "True")]
        [DataRow("abc-100@yahoo.com,", "True")]
        [DataRow("abc.100@yahoo.com", "True")]
        [DataRow("abc111@abc.com,", "True")]
        [DataRow("abc-100@abc.net,", "True")]
        [DataRow("abc.100@abc.com.au", "True")]
        [DataRow("abc@1.com,", "True")]
        [DataRow("abc@gmail.com.com", "True")]
        [DataRow("abc+100@gmail.com", "True")]
        [DataRow("abc", "Please enter a Valid EmailID!")]
        [DataRow("abc@.com.my", "Please enter a Valid EmailID!")]
        [DataRow("abc123@gmail.a", "Please enter a Valid EmailID!")]
        [DataRow("abc123@.com", "Please enter a Valid EmailID!")]
        [DataRow("abc123@.com.com", "Please enter a Valid EmailID!")]
        [DataRow(".abc@abc.com", "Please enter a Valid EmailID!")]
        [DataRow("abc()*@gmail.com", "Please enter a Valid EmailID!")]
        [DataRow("abc..2002@gmail.com", "Please enter a Valid EmailID!")]
        [DataRow("abc.@gmail.com", "Please enter a Valid EmailID!")]
        [DataRow("abc@abc@gmail.com", "Please enter a Valid EmailID!")]
        [DataRow("abc@gmail.com.1a", "Please enter a Valid EmailID!")]
        [DataRow("abc@gmail.com.aa.au", "Please enter a Valid EmailID!")]
        [DataRow("abc@%*.com", "Please enter a Valid EmailID!")]
        public void TestSampleEmails(string email, string expected)
        {
            User_Registration user = new User_Registration();
            string actual = user.SampleEmail(email);

            Assert.AreEqual(expected,actual);
        }

    }
}