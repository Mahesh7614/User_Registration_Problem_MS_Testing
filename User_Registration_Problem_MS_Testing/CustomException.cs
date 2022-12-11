
namespace User_Registration_Problem_MS_Testing
{
    public class CustomException : Exception
    {
        ExceptionType Type;
        public enum ExceptionType
        {
            EMPTY_MESSAGE, NULL_MESSAGE, INVALID_MESSAGE
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            Type = type;
        }
    }
}
