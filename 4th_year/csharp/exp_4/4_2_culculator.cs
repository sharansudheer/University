//Initial Commit
//No need for operater overloading

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    delegate void Check(int a1, int a2);
    class Program
    {
        public event Check MyEvent;
        int s1, s2;

        public Program()
        {
            s1 = 0;
            s2 = 0;
        }
        public Program (int n1, int n2)
        {
            s1 = n1;
            s2 = n2;
        }
       

        public void sum(int a, int b) { Console.WriteLine(a + b); }
        public void sub(int a, int b) { Console.WriteLine(a - b); }
        public void mul(int a, int b) { Console.WriteLine(a * b); }



        static void Main(string[] args)
        {
            Program p = new Program();        
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            p.MyEvent = new Check(p.sum);
            p.MyEvent(a, b);

           
            

           
            Console.ReadLine();
        }


    }

}



