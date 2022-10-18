//"Du hast nichts davon verdient. Aber manchmal trifft es die Guten am Härtesten." 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class books
    {
        string[] book_name = { "Java", "C++", "Python", "C#" };
        int[] book_id = { 1, 2, 3, 4 };

        public void booksearch(string name)
        {

            try
            {
                bool t = false;

                for (int i = 0; i < 4; i++)
                {
                    if (book_name[i].Equals(name) == true)
                    {
                        t = true;
                        break;
                    }
                }

                if (t == true)
                {
                    Console.WriteLine("Book is Present");
                }
                else
                {
                    throw new NobookException();
                }
            }
            catch (NobookException e)
            {
                Console.WriteLine("Error:-" + e);
            }
        }
    }

    public class NobookException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return string.Format("Book Not Found");
            }
        }

    }
    class users
    {
        string[] user_name = { "Ramesh", "Suresh", "Rajesh", "Rakesh" };

        public void valid_user(string name)
        {

            try
            {
                bool t = false;

                for (int i = 0; i < 4; i++)
                {
                    if (user_name[i].Equals(name) == true)
                    {
                        t = true;
                        break;
                    }
                }

                if (t == true)
                {
                    throw new AlreadyIssuedException();
                }
                else
                {
                    Console.WriteLine("Valid User");

                }
            }
            catch (AlreadyIssuedException e)
            {
                Console.WriteLine("Error:-" + e);
            }
        }
    }

    public class AlreadyIssuedException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return string.Format("Cannot Issue More than 1 Book");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("**Library Management**");
                string ch;
                do
                {
                    Console.WriteLine("1.Search Book\n2.Issue Book to User\n3.Exit");
                    ch = Console.ReadLine();

                    if (ch == "1")
                    {
                        Console.WriteLine("Enter Book Name:-");
                        string name = Console.ReadLine();
                        books b = new books();
                        b.booksearch(name);
                        break;
                    }
                    else if (ch == "2")
                    {
                        //code for valid user
                        Console.WriteLine("Enter User Name to Issue Book:-");
                        string name = Console.ReadLine();
                        users u = new users();
                        u.valid_user(name);
                        break;

                    }
                    else { }

                } while (!ch.Equals("3"));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:-" + e);
            }

            Console.ReadLine();
        }
    }
}
