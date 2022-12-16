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


    }
}
