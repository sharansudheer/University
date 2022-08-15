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
        //
        // + opertor overloading
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
        //
        // " - "  subtraction opertor
        public static complex operator -(complex c1, complex c2)
        {
            complex temp = new complex();
            temp.real = c1.real - c2.real;
            temp.img = c1.img - c2.img;
            return temp;
        }
        public void Display()
        {
            Console.WriteLine($"{real} + i{img}");
        }
        //
        // " / " Divison opertor overloading
        public static complex operator /(complex c1, complex c2)
        {
            complex temp = new complex();
            if (c2.real && c2.img !=0){
                temp.real = c1.real / c2.real;
                temp.img = c1.img / c2.img;
                return temp;
            }
            else{

            }          
        }
        public void Display()
        {
            Console.WriteLine($"{real} + i{img}");
        }
        //
        // " * " opertor
        public static complex operator *(complex c1, complex c2)
        {
            complex temp = new complex();
            if (c1.real||c2.real||c2.img||c2.img !=0){
                temp.real = c1.real * c2.real;
                temp.img = c1.img * c2.img;
                return temp;
            }
            else{
                temp.real=0;
                temp.img=0;
            }
                
        }
        public void Display()
        {
            if(real||img!=0){
                Console.WriteLine($"{real} + i{img}");
            }
            else{
                Console.WriteLine(0);
            }
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
