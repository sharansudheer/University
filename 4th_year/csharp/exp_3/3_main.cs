//operator overloading
using System;
namespace OperatorOverloading
{
    public class complex
    {
        private int real;
        private int img;
        public complex(int r = 0, int i = 0)
        {
            real = r;
            img = i;
        }
        public static complex operator +(complex c1, complex c2)
        {
            complex temp = new complex();
            temp.real = c1.real + c2.real;
            temp.img = c1.img + c2.img;
            return temp;
        }
        public void Display()
        {
            Console.WriteLine($"{real} + i{img}");
        }
    };

    class Program
    {
        static void Main(string[] args)
        {
            complex c1 = new complex(3, 7);
            c1.Display();
            complex c2 = new complex(5, 2);
            c2.Display();
            complex c3 = c1 + c2;
            c3.Display();
            Console.ReadKey();
        }
    }

    
}
