//operator overloading Oppenheimer
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
        
        //
        // " - "  subtraction opertor
        public static complex operator -(complex c1, complex c2)
        {
            complex temp = new complex();
            temp.real = c1.real - c2.real;
            temp.img = c1.img - c2.img;
            return temp;
        }
        
        //
        // " / " Divison opertor overloading
        public static complex operator /(complex c1, complex c2)
        {
            complex temp = new complex();
            //if ((c2.real & c2.img) != 0){
                temp.real = c1.real / c2.real;
                temp.img = c1.img / c2.img;
                return temp;
            //}
                   
        }
       
        //
        // " * " opertor
        public static complex operator *(complex c1, complex c2)
        {
            complex temp = new complex();
            //if (c1.real|c2.real|c2.img|c2.img !=0){
                temp.real = c1.real * c2.real;
                temp.img = c1.img * c2.img;
                return temp;
            //}
            /* else{
                temp.real=0;
                temp.img=0;
            } */
                
        }
        public void Display()
        {
            //if(real|img!=0){
                Console.WriteLine($"{real} + i{img}");
            //}
            //else{
                //Console.WriteLine(0);
            //}
        }
    };

    class Program
    {
        static void Main(string[] args)
        {
            complex c1 = new complex(3, 7);
          
            complex c2 = new complex(5, 2);
            
            complex c4 = c1 + c2;
            c4.Display();
            complex c5 = c1 - c2;
            c5.Display();
            complex c6 = c1 * c2;
            c6.Display();
            complex c7 = c1 / c2;
            c7.Display();
            
        }
    }
}

/*
    try  
    {  
    int i = 20;  
    // Suspect code  
    int result = i / 0;  
    }  
    catch (DivideByZeroException ex)  
    {  
    Console.WriteLine("Attempted divide by zero. {0}", ex.Message);  
    }  
  */  
