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
            Console.WriteLine("choose option 1.firstname");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    UC1RegexFirstName.ValidFirstName();
                    break;
                default:
                    Console.WriteLine("enter wrong choice");
                    break;
            }
        }
    }
}
