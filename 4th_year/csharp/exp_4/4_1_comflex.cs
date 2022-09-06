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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Delhi c1 = new Delhi(3, 7);
            Delhi c2 = new Delhi(5, 2);
            complex oprat = Delhi.Sum;
            /* complex[] oprat = { Delhi.Sum, Delhi.Multi}; // delegate instance creation
             complex action;
            Delhi ev = new Delhi();
            ev.Comp += new complex(Delhi.Sum);
            ev.Comp(c1,c2); 
            
            /* 
            unwanted
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
