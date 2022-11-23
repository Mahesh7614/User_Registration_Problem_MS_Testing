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
    }
}
