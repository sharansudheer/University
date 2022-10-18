// H.G. Tannhaus  : “What if everything that came from the past was influenced by the future.”

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Age
    {
        int valid_age = 18;

        public void check_age(int age)
        {

            try
            {
                bool t = false;

                if (age < 18)
                {
                    t = true;
                }


                if (t == true)
                {
                    Console.WriteLine("Valid Age");
                }
                else
                {
                    throw new InvalidAgeException();
                }
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine("Error:-" + e);
            }
        }
    }

    public class InvalidAgeException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return string.Format("Invalid Age , Greater than 18");
            }
        }

    }
    class Phoneno
    {
        long phoneno_check = 9999999999;

        public void valid_phoneno(long phone_number)
        {

            try
            {
                bool t = false;

                if (phoneno_check < phone_number)
                {
                    t = true;
                }

                if (t == true)
                {
                    throw new InvalidPhonenoException();
                }
                else
                {
                    Console.WriteLine("Valid Phone Number");

                }
            }
            catch (InvalidPhonenoException e)
            {
                Console.WriteLine("Error:-" + e);
            }
        }
    }

    public class InvalidPhonenoException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return string.Format("Enter Phone Number of 10 Digits");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("**Student Information System**");

                Console.WriteLine("Enter Name:-");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Age:-");
                int age = int.Parse(Console.ReadLine());
                Age a = new Age();
                a.check_age(age);

                Console.WriteLine("Enter Phone Number:-");
                long ph_no = long.Parse(Console.ReadLine());
                Phoneno p = new Phoneno();
                p.valid_phoneno(ph_no);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error:-" + e);
            }

            Console.ReadLine();
        }
    }
}
