// Noah : “But every now and then it’s good to question those who question things.”
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**Online Ticket Booking**");

            Console.WriteLine("Enter your E-Mail ID:-");

            string email = Console.ReadLine();
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                Console.WriteLine("Valid Email Address and you can continue to create password");
            }
            else
            {
                Console.WriteLine(email + " is Invalid Email Address ,Enter Again:-");
                email = Console.ReadLine();
            }

            Console.WriteLine("Enter Password with atleast 1 Upper Case,Lower Case,Special Character,Digit");
            string pass = Console.ReadLine();
            bool smallchar = false;
            bool upperchar = false;
            bool digit = false;
            bool spclchar = false;

            var regexItem = new Regex(@"[a-z]+");

            if (regexItem.IsMatch(pass))
            {
                smallchar = true;
                Console.WriteLine("Pass1");
            }

            var regexItem1 = new Regex(@"[A-Z]+");

            if (regexItem1.IsMatch(pass))
            {
                upperchar = true;
                Console.WriteLine("Pass2");
            }

            var regexItem2 = new Regex(@"[0-9]+");

            if (regexItem2.IsMatch(pass))
            {
                digit = true;
                Console.WriteLine("Pass3");
            }

            var regexItem3 = new Regex(@"[*&@#$!]+");

            if (regexItem3.IsMatch(pass))
            {
                spclchar = true;
                Console.WriteLine("Pass4");
            }

            bool reenter = true;


            if (smallchar == false)
            {
                Console.WriteLine("Enter Atleast 1 Lower Case letter");
                reenter = false;
            }
            if (upperchar == false)
            {
                Console.WriteLine("Enter Atleast 1 Upper Case letter");
                reenter = false;
            }
            if (digit == false)
            {
                Console.WriteLine("Enter Atleast 1 Digit");
                reenter = false;
            }
            if (spclchar == false)
            {
                Console.WriteLine("Enter Atleast 1 Special Case letter");
                reenter = false;
            }

            if (reenter == false)
            {
                Console.WriteLine("Enter Password Again:-");
                pass = Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
