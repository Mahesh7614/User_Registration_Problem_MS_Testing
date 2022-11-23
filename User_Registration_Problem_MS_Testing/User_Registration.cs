using System;
using System.Text.RegularExpressions;

namespace User_Registration_Problem_MS_Testing
{
    public class User_Registration
    {
        public bool FirstNameAndLastName(string Name)
        {
            Regex firstLastName = new Regex(@"^([A-z]{1}[a-z]{2,})$");
            bool matches = firstLastName.IsMatch(Name);

            return matches;
        }
        public bool Email(string email)
        {

            Regex emailID = new Regex(@"^(abc)[a-zA-Z0-9_\+\-\.]*[@](bl)*[.](co)*[.][a-z]{3}$");
            bool matches = emailID.IsMatch(email);
            return matches;
        }
        public bool MobileNumber(string mobileNumber)
        {

            Regex number = new Regex(@"^*[+][1-9]{1,3}\s[1-9]{1}[0-9]{9}$");
            bool matches = number.IsMatch(mobileNumber);
            return matches;
        }
        public bool PassWord(string password)
        {

            Regex pass = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$");
            bool matches = pass.IsMatch(password);
            return matches;
        }
    }
}
