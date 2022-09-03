//Initial Commit
//No need for operater overloading

using System;


namespace csharp_lab
{
    public class calculator
    {   
        public int temp;
        //
        // + opertor overloading
        public int add(int c1, int c2)
        {
            
            temp = c1 + c2;
            return temp;
        }

        //
        // " - "  subtraction opertor
        public int subtract(int c1, int c2)
        {

            
            temp = c1 - c2;
            return temp;
        }

        //
        // " / " Divison opertor overloading
        public int division(int c1, int c2)
        {

            //if ((c2 & c2) != 0){
            temp = c1 / c2;
            return temp;
            //}

        }

        //
        // " * " opertor
        public int multi(int c1, int c2)
        {

            //if (c1|c2|c2|c2 !=0){
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
            calculator cal = new calculator();

           

        }
    }
}

