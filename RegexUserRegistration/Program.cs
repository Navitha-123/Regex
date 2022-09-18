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
            Console.WriteLine("choose option 1.firstname \t 2.lastname \t 3.email \t 4. mobile number \t 5.rule1 password \t 6. rule2 password \t 7.Rule 3 password \t8.rule4 password");

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
                case 6:
                    Console.WriteLine("enter a password ");
                    string input1 = Console.ReadLine();
                    UC6PassWordUpperCase.ValidPassWord(input1);
                    break;
                case 7:
                    Console.WriteLine("enter a password");
                    string input2 = Console.ReadLine();
                    UC7PasswordNumeric.ValidPassWord(input2);
                    break;
                case 8:
                    Console.WriteLine("enter a password");
                    string input3 = Console.ReadLine();
                    UC8PasswordSpecialChar.ValidPassWord(input3);
                    break;
                default:
                    Console.WriteLine("enter wrong choice");
                    break;
            }
        }
    }
}
