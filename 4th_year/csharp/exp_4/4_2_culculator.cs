using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public delegate string Check(string str);
    class Program
    {
        event Check MyEvent;

        public Program()
        {
            this.MyEvent += new Check(this.User);
        }
        public string User(string str)
        {
            return str;
        }
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);
        public delegate void mulnum(int a, int b);

        public void sum(int a, int b) { Console.WriteLine(a + b); }
        public void sub(int a, int b) { Console.WriteLine(a - b); }
        public void mul(int a, int b) { Console.WriteLine(a * b); }



        static void Main(string[] args)
        {
            bool trig=true;
            Program p = new Program();
            addnum add_del = new addnum(p.sum);
            subnum sub_del = new subnum(p.sub);
            mulnum mul_del = new mulnum(p.mul);
            
            while(trig != false)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                if (a < 0 || b < 0)
                {
                    Program obj1 = new Program();
                    string result = obj1.MyEvent("Enter Number Greater than 0");
                    Console.WriteLine(result);
                  
                  

                }
                else
                {
                    add_del(a, b);
                    sub_del(a, b);
                    mul_del(a, b);
                    trig = false;
                }
            } 


            
            Console.ReadLine();
        }


    }

}
