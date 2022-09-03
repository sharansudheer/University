//Initial Commit
//No need for operater overloading
using csharp_lab;
using System;

namespace csharp_lab
{
    public class complex
    {
        private int real;
        private int img;
        
        
        //
        // + opertor overloading
        public int add(int c1, int c2)
        {
            int temp = 0;
            temp = c1 + c2;
            return temp;
        }

    //
    // " - "  subtraction opertor
    public int subtract  (int c1, int c2)
        {
            
            int temp = 0;
            temp = c1 - c2;            
            return temp;
        }

//
// " / " Divison opertor overloading
    public int division(int c1, int c2)
    {
        int temp = 0;
        //if ((c2 & c2) != 0){
        temp = c1 / c2;
        temp = c1 / c2;
        return temp;
        //}

    }

    //
    // " * " opertor
    public int multi(int c1, int c2)
    {

            //if (c1|c2|c2|c2 !=0){
        int temp = 0;
        temp = c1 * c2;
        temp = c1 * c2;
        return temp;
        //}
        /* else{
            temp=0;
            temp=0;
        } */

    }
    public void Display()
    {
        //if(real|img!=0){
        Console.WriteLine($"{temp}");
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
            // try catch
            int c1 = new complex(3, 7);

            int c2 = new complex(5, 2);

            int c4 = c1 + c2;
            c4.Display();
            int c5 = c1 - c2;
            c5.Display();
            int c6 = c1 * c2;
            c6.Display();
            int c7 = c1 / c2;
            c7.Display();

        }
    }
}
