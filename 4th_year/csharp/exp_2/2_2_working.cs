using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;  
namespace ConsoleApplication1
{
   
    class library
    {
        
        
        abstract class books
        {
            public ArrayList kitabe = new ArrayList();
            public abstract void showbook();
            public void addbook(string book_name)
            {
                //Console.WriteLine(book_name);
                kitabe.Add(book_name);
            }
            public void removebook(string book_name)
            {
                kitabe.Remove(book_name);
            }
        }
        class Admin : books
        {
           
            public override void showbook()
            {
                foreach (var item in kitabe) {
                    Console.WriteLine("Book Name:"+item);
                }
            }
          
        }
        class User : books
        {
            public string name;

            public User(string user_name) {
                name = user_name;
            }

            public override void showbook()
            {
                foreach (var book in kitabe)
                {
                    Console.WriteLine("Book Name:"+book);
                }
            }
            public void issuebook()
            {
         

                string issue_book = Console.ReadLine();

                Console.WriteLine(issue_book+" is issued to "+name);
            }

        }
        static void Main(string[] args)
        {
            Console.ReadLine();
            User u = new User("JOshh");
            Admin a = new Admin();
           
            a.addbook("Harry Potter");
            a.addbook("Twilight");
            a.addbook("Goosebumps");
            Console.WriteLine("Choose any 1 Book from the Available Book");
            a.showbook();
            u.issuebook();
            a.removebook("Harry Potter");
            a.showbook();
            Console.ReadLine();
            

        }
    }
}
