﻿namespace User_Registration_Problem_MS_Testing
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
        }
    }
}