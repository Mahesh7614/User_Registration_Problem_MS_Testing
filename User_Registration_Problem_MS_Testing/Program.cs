namespace User_Registration_Problem_MS_Testing
{
    public class Program
    {
        static void Main(string[] args)
        {
            User_Registration user = new User_Registration();
            Console.Write("Enter First Name : ");
            string firstName = Console.ReadLine();
            Console.WriteLine(user.FirstNameAndLastName(firstName));

            Console.Write("Enter Last Name : ");
            string LastName = Console.ReadLine();
            Console.WriteLine(user.FirstNameAndLastName(LastName));

            Console.Write("Enter Email ID : ");
            string email = Console.ReadLine();
            Console.WriteLine(user.Email(email));

            Console.Write("Enter Mobile Number with Country Code and Space between them : ");
            string mobileNumber = Console.ReadLine();
            Console.WriteLine(user.MobileNumber(mobileNumber));

            Console.WriteLine("Enter Password min 8 Characters : ");
            string password = Console.ReadLine();
            Console.WriteLine(user.PassWord(password));

        }
    }
}