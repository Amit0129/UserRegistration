using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Pattern
    {
        public bool Validater(string inputString, string pattern)
        {
            return Regex.IsMatch(inputString, pattern);
        }
        public void FirstNameCheck()
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Enter First Name");
                string firstName = Console.ReadLine();
                string fstNamePattern = "^[A-Z][A-Za-z]{2,}$";
                if (Validater(firstName, fstNamePattern))
                {
                    Console.WriteLine($"The First Name of The Person is {firstName}");
                    check = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid FirstName Where first letter must be in capital and it contain minimun three charectar");
                }
            }
        }

        public void LastNameCheck()
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Enter Last Name");
                string lastName = Console.ReadLine();
                string lstNamePattern = "^[A-Z][A-Za-z]{2,}$";
                if (Validater(lastName, lstNamePattern))
                {
                    Console.WriteLine($"The Last Name of The Person is {lastName}");
                    check = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid LastName Where first letter must be in capital and it contain minimun three charectar");
                }
            }
        }

        public void EmailCheck()
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Enter your Mail Id");
                string emailId = Console.ReadLine();
                
                string emailIdPattern = @"^[a-zA-Z0-9]+([._+-][0-9a-zA-Z]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";
                if (Validater(emailId, emailIdPattern))
                {
                    Console.WriteLine($"The Email id {emailId} is valid");
                    check = false;
                    break;
                }
                else
                {
                    Console.WriteLine($"Email id {emailId} is Invalid");
                }
            }
        }

        public void MobileNumberCheck()
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Enter Mobile Number");
                string mobileNumber = Console.ReadLine();
                string mobNumberPattern = "^[0-9]{2}[ ][6-9][0-9]{9}$";
                if (Validater(mobileNumber, mobNumberPattern))
                {
                    Console.WriteLine($"The Mobile Number is {mobileNumber}");
                    check = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid Mobile Number");
                }
            }
        }

        public void PasswordCheck()
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();
                string passwordPattern = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=[^!@#$%_]*[!@#$%_][^!@#$%_]*$)[A-Za-z0-9!@#$%_]{8,}$";
                if (Validater(password, passwordPattern))
                {
                    Console.WriteLine($"The passwoed is {password}");
                    check = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid Password that have minimum 8 Characters and Atlist one upper case Chareacter");
                }
            }
        }


    }
}
