using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose option 1.firstname \t 2.lastname \t 3.email \t 4. mobile number");

            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    UC1RegexFirstName.ValidFirstName();
                    break;
                case 2:
                    UC2RegexLastName.ValidLastName();
                    break;
                case 3:
                    UC3Email.ValidEmailAddress();
                    break;
                case 4:
                    UC4MobileNumber.ValidMobileNumber();
                    break;
                default:
                    Console.WriteLine("enter wrong choice");
                    break;
            }
        }
    }
}
