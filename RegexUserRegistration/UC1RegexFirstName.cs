using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    internal class UC1RegexFirstName
    {
        public static void ValidFirstName()
        {
            Console.WriteLine("Enter first name");
            string firstname = Console.ReadLine();
            string pattern = "^[A-Z],{3}";
            if(Regex.IsMatch(firstname, pattern))
            {
                Console.WriteLine("valid first name");

            }
            else
            {
                Console.WriteLine("In valid first name");
            }
        }
    }
}
