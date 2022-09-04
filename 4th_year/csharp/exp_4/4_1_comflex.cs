
using OperatorOverloading;
using System;
using static OperatorOverloading.Delhi;

namespace OperatorOverloading
{
    public class Delhi 
    {
        public delegate void complex(int c1, int c2);
        private int real;
        private int img;
        public Delhi(int r = 0, int i = 0)
        {
            real = r;
            img = i;
        }
        //
        // + opertor overloading
        public static Delhi Sum(Delhi c1, Delhi c2)
        {   
            /*
              Object initialization can be simplified
              Remove unused parameter 'args'
             */
            Delhi temp = new Delhi();
            temp.real = c1.real + c2.real;
            temp.img = c1.img + c2.img;
            return temp;

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
            Delhi c1 = new Delhi(3, 7);
            Delhi c2 = new Delhi(5, 2);




        }
    }
}
/* 
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates
https://www.geeksforgeeks.org/c-sharp-program-to-demonstrate-the-example-of-an-array-of-delegates/
 */
