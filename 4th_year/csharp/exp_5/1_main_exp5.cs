// Martha: “We all face the same end. Those above have long forgotten us."


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
            while (true)
            {

                Console.WriteLine("Main Menu");
                Console.WriteLine("1. String Operation");
                Console.WriteLine("2. Regular Expression");
                Console.WriteLine("3. Exit");
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("***String Operation***");

                        Console.WriteLine("1. Length of the String");
                        Console.WriteLine("2. Remove from String");
                        Console.WriteLine("3. Replace from String");
                        Console.WriteLine("4. To Upper");
                        Console.WriteLine("5. To Lower");
                        Console.WriteLine("6. Split String");
                        Console.WriteLine("7. Insert into string");
                        Console.WriteLine("8. Copy String");
                        Console.WriteLine("9. Contains to");
                        Console.WriteLine("10. Join");
                        Console.WriteLine("11. Substring");
                        Console.WriteLine("12. Exit");
                        int x = int.Parse(Console.ReadLine());

                        if (x == 1)
                        {
                            string s = "Exhorts us to plan and work hard like the plan who store up the food in summer";
                            Console.WriteLine("String is:" + s);
                            Console.WriteLine("Length:" + s.Length);
                        }
                        else if (x == 2)
                        {
                            string s = "Exhorts us to plan and work hard like the plan who store up the food in summer";
                            Console.WriteLine("Enter the Index to Remove from:-");
                            int c = int.Parse(Console.ReadLine());
                            Console.WriteLine("String is:" + s);
                            Console.WriteLine("After Removal:" + s.Remove(c));
                        }
                        else if (x == 3)
                        {
                            string s = "Exhorts us to plan and work hard like the plan who store up the food in summer";
                            Console.WriteLine("String is:" + s);
                            Console.WriteLine("Enter the String to Replace:-");
                            string r = Console.ReadLine();
                            Console.WriteLine("Enter the String to Replace with:-");
                            string r1 = Console.ReadLine();
                            Console.WriteLine("After Replace: " + s.Replace(r, r1));


                        }
                        else if (x == 4)
                        {
                            string s = "Exhorts us to plan and work hard like the plan who store up the food in summer";
                            Console.WriteLine("String is:" + s);
                            string s1 = s.ToUpper();
                            Console.WriteLine("To Upper: " + s1);

                        }
                        else if (x == 5)
                        {
                            string s = "Exhorts us to plan and work hard like the plan who store up the food in summer";
                            Console.WriteLine("String is:" + s);
                            string s1 = s.ToLower();
                            Console.WriteLine("To Lower: " + s1);

                        }
                        else if (x == 6)
                        {
                            string s = "Exhorts us to plan and work hard like the plan who store up the food in summer";
                            Console.WriteLine("String is:" + s);
                            char separator = ' ';
                            String[] sep = s.Split(separator);
                            Console.WriteLine("Spliting on Spaces");
                            foreach (String u in sep)
                            {
                                Console.WriteLine(u);
                            }

                        }
                        else if (x == 7)
                        {
                            string s = "Exhorts us to plan and work hard like the plan who store up the food in summer";
                            Console.WriteLine("String is:" + s);
                            Console.WriteLine("Enter the Index to Insert at:-");
                            int index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the String to Insert");
                            string value = Console.ReadLine();
                            Console.WriteLine("After the Insert: " + s.Insert(index, value));

                        }
                        else if (x == 8)
                        {
                            string s = "Exhorts us to plan and work hard like the plan who store up the food in summer";
                            Console.WriteLine("String is:" + s);
                            string s2 = "hello world";
                            Console.WriteLine("Before Copy:- " + s2);
                            s2 = String.Copy(s);
                            Console.WriteLine("After Copy:-" + s2);

                        }
                        else if (x == 9)
                        {
                            string s = "Exhorts us to plan and work hard like the plan who store up the food in summer";
                            Console.WriteLine("String is:" + s);
                            Console.WriteLine("Enter the Substring to Check:-");
                            string s1 = Console.ReadLine();
                            Console.WriteLine("Contains the Substring ? :- " + s.Contains(s1));

                        }
                        else if (x == 10)
                        {
                            string[] bs = { "one", "two", "three", "four", "five" };
                            Console.WriteLine("Before Join:-");
                            foreach (string s in bs)
                            {
                                Console.WriteLine(s);
                            }

                            string new_bs = string.Join("-", bs);
                            Console.WriteLine("After Joining with -" + new_bs);


                        }
                        else if (x == 11)
                        {
                            string s = "Exhorts us to plan and work hard like the plan who store up the food in summer";
                            Console.WriteLine("String is:" + s);
                            Console.WriteLine("Enter the Start Index of the Substring-");
                            int ind = int.Parse(Console.ReadLine());
                            Console.WriteLine("Substring:-" + s.Substring(ind));
                        }
                        else if (x == 12)
                        {
                            break;
                        }
                        else
                        {
                            //
                        }



                    }

                }
                else if (n == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("***Regular Expression***");

                        Console.WriteLine("1. Find Word with Title Case");
                        Console.WriteLine("2. Find Word with Lower Case");
                        Console.WriteLine("3. Find Digits");
                        Console.WriteLine("4. Split URL");
                        Console.WriteLine("5. Validate Email Id");
                        Console.WriteLine("6. Validate Registration Number");
                        Console.WriteLine("7. Exit");
                        int x = int.Parse(Console.ReadLine());

                        if (x == 1)
                        {
                            String s = "Exhorts us to plan and work hard Like the plan who store up the Food in summer";
                            Console.WriteLine("String is:" + s);

                            Regex regexp = new Regex(@"\b[A-Z]\S*");

                            MatchCollection matches = regexp.Matches(s);

                            foreach (Match m in matches)
                            {
                                if (m.Length != 0)
                                {
                                    Console.WriteLine(m);
                                }
                            }

                        }
                        else if (x == 2)
                        {
                            String s = "Exhorts us to plan and work hard Like the plan who store up the Food in summer";
                            Console.WriteLine("String is:" + s);

                            Regex regexp = new Regex(@"\b[a-z]\S*");

                            MatchCollection matches = regexp.Matches(s);

                            foreach (Match m in matches)
                            {
                                if (m.Length != 0)
                                {
                                    Console.WriteLine(m);
                                }
                            }


                        }
                        else if (x == 3)
                        {
                            String s = "Exhorts 1 us to plan and 23 work hard Like the plan 56 who store up the Food in summer";
                            Console.WriteLine("String is:" + s);

                            Regex regexp = new Regex(@"\b\d\S*");

                            MatchCollection matches = regexp.Matches(s);

                            foreach (Match m in matches)
                            {
                                if (m.Length != 0)
                                {
                                    Console.WriteLine(m);
                                }
                            }

                        }
                        else if (x == 4)
                        {
                            String s = "https://view.karunya.edu";

                            string[] url = Regex.Split(s, @"[.://]");

                            foreach (string value in url)
                            {


                                Console.WriteLine(value);

                            }

                        }
                        else if (x == 5)
                        {

                            string email = "helloworld@gmail.com";
                            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                            Match match = regex.Match(email);
                            if (match.Success)
                                Console.WriteLine(email + " is Valid Email Address");
                            else
                                Console.WriteLine(email + " is Invalid Email Address");


                        }
                        else if (x == 6)
                        {

                            //validate Registration Number
                            Console.WriteLine("Enter Registration Number to Validate:-");
                            string reg_no = Console.ReadLine();
                            Regex regex = new Regex(@"[U|P|R][R|L|P][K|C][0-9]{2}CS[0-9]{4}");
                            Match match = regex.Match(reg_no);
                            if (match.Success)
                            {
                                Console.WriteLine(reg_no + " is Valid Registration Number");
                            }
                            else
                            {
                                Console.WriteLine(reg_no + " is Invalid Registration Number");
                            }

                        }
                        else
                        {
                            //
                        }
                    }


                }
                else
                {
                    break;
                }


            }

        }
    }
}
