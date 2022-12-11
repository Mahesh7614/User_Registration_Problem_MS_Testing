using System.Text.RegularExpressions;

namespace User_Registration_Problem_MS_Testing
{
    public class User_Registration
    {
        static Regex firstLastName = new Regex(@"^([A-z]{1}[a-z]{2,})$");
        static Regex emailID = new Regex(@"^(abc)[a-zA-Z0-9_\+\-\.]*[@](bl)*[.](co)*[.][a-z]{3}$");
        static Regex number = new Regex(@"^*[+][1-9]{1,3}\s[1-9]{1}[0-9]{9}$");
        static Regex pass = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");
        static Regex email = new Regex(@"^(abc)([_\+\-\.]{0,1}[a-zA-Z0-9])*[@][a-z0-9]{1,} *[.][a-z]{2,}[\.\,]{0,}[a-z]{0,}$");
        public Func<string, string> FirstNameAndLastName = (Name) =>
        {
            try
            {
                if (Name == null)
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Name Should Not be Null");
                }
                if (Name.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Name Should Not be Empty");
                }
                if (firstLastName.IsMatch(Name))
                {
                    return firstLastName.IsMatch(Name).ToString();
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "Please enter a Valid Name!");

                }

            }
            catch (CustomException ex)
            {
                return ex.Message;
            }

        };
        public Func<string, string> Email = (email) =>
        {
            try
            {
                if (email == null)
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Email Should Not be Null");
                }
                if (email.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Email Should Not be Empty");
                }
                if (emailID.IsMatch(email))
                {
                    return emailID.IsMatch(email).ToString();
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "Please enter a Valid Email!");

                }

            }
            catch (CustomException ex)
            {
                return ex.Message;
            }
        };
        public Func<string, string> MobileNumber = (mobileNumber) =>
        {
            try
            {
                if (mobileNumber == null)
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Mobile Number Should Not be Null");
                }
                if (mobileNumber.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mobile Number Should Not be Empty");
                }
                if (number.IsMatch(mobileNumber))
                {
                    return number.IsMatch(mobileNumber).ToString();
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "Please enter a Valid Mobile Number!");

                }

            }
            catch (CustomException ex)
            {
                return ex.Message;
            }
        };
        public Func<string, string> PassWord = (password) =>
        {
            try
            {
                if (password == null)
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Password Should Not be Null");
                }
                if (password.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Password Should Not be Empty");
                }
                if (pass.IsMatch(password))
                {
                    return pass.IsMatch(password).ToString();
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "Please enter a Valid Password!");

                }

            }
            catch (CustomException ex)
            {
                return ex.Message;
            }
        };
        public Func<string, string> SampleEmail = (emailID) =>
        {
            try
            {
                if (emailID == null)
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "EmailID Should Not be Null");
                }
                if (emailID.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "EmailID Should Not be Empty");
                }
                if (email.IsMatch(emailID))
                {
                    return email.IsMatch(emailID).ToString();
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "Please enter a Valid EmailID!");

                }

            }
            catch (CustomException ex)
            {
                return ex.Message;
            }
        };
    }
}
