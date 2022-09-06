using OperatorOverloading;
using System;
using static OperatorOverloading.Delhi;

/*
 SECRET SAUCE FOR DELEGATES IN ORDER
1) Delgate Delcartion
2) Delegate Method Definition
3) Delegate Instance Creation
4) Delegate Function invovation
 */

namespace OperatorOverloading
{
    public delegate void complex(Delhi c1, Delhi c2); //Delegate declaration    
    public class Delhi
    {
        public event complex Comp; //event declaration
        private int real;
        private int img;
        public Delhi()
        {
            real = 0;
            img = 0;
        }
        public Delhi(int r = 0, int i = 0)
        {
            real = r;
            img = i;
        }
        //
        // + opertor overloading
        public static void Sum(Delhi c1, Delhi c2) //delegate method definition, event handler method
        {
            /*
              Object initialization can be simplified
              Remove unused parameter 'args'
             */
            Delhi temp = new Delhi();
            temp.real = c1.real + c2.real;
            temp.img = c1.img + c2.img;
            Console.WriteLine($"{temp.real} + i{temp.img}");

        }
        // " - "  subtraction opertor
        public static void Sub(Delhi c1, Delhi c2)
        {
            Delhi temp = new Delhi();
            temp.real = c1.real - c2.real;
            temp.img = c1.img - c2.img;
            Console.WriteLine("\n Subtraction");
            Console.WriteLine($"{temp.real} + i{temp.img}");

        }


        //
        // " * " opertor
        public static void Mul(Delhi c1, Delhi c2)
        {

            //if (c1.real|c2.real|c2.img|c2.img !=0){
            Delhi temp = new Delhi();
            temp.real = c1.real * c2.real;
            temp.img = c1.img * c2.img;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Delhi c1 = new Delhi(3, 7);
            Delhi c2 = new Delhi(5, 2);
            complex oprat = Delhi.Sum;
            /*complex[] oprat = { Delhi.Sum, Delhi.Multi}; // delegate instance creation */
            
            Delhi ev = new Delhi();
            ev.Comp += new complex(Delhi.Sum);
            ev.Comp(c1,c2); 
            
            
            

            Console.ReadKey();


        }
    }
}
/* 
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates
https://www.geeksforgeeks.org/c-sharp-program-to-demonstrate-the-example-of-an-array-of-delegates/
 */
//
/* 

 */
/* 
            unwanted
complex oprat = Delhi.Sum;
            complex action;
            action = oprat[n-1]
            action(c1,c2); // delegate invocation
             */

/* 
 //Multicast Delegates
 complex oprat1 = Delhi.Sum;
complex oprat2 = Delhi.Sub;
complex oprat3 = Delhi.Mul;
complex rat = oprat1 + oprat2 + oprat3;
rat(c1,c2);
 */
