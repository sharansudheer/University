// Vector Operations
using System;
namespace OperatorOverloading
{
    public class vector
    {
        private int x;
        private int y;
        private int z;

        public vector(int a = 0, int b = 0, int c = 0)
        {
            x = a;
            y = b;
            z = c;
        }
        //
        // + opertor overloading
        public static vector operator +(vector c1, vector c2)
        {
            vector temp = new vector();
            temp.x = c1.x + c2.x;
            temp.y = c1.y + c2.y;
            temp.z = c1.z + c2.z;
            return temp;
        }
        
        //
        // " - "  subtraction opertor
        public static vector operator -(vector c1, vector c2)
        {
            vector temp = new vector();
            temp.x = c1.x - c2.x;
            temp.y = c1.y - c2.y;
            temp.z = c1.z - c2.z;
            return temp;
        }
        
        //
        // " / " Divison opertor overloading
        public static vector operator /(vector c1, vector c2)
        {
            /* 
            Opertor overloading requires a 
            return statement and return cannot be void. 
            How to fix it??
            if ((c2.x & c2.y & c2.z) != 0){
            .......
            }else {
                Console.WriteLine("ZZ");
                return;}
            */
            vector temp = new vector();
            //if ((c2.x && c2.y) != 0){
                temp.x = c1.x / c2.x;
                temp.y = c1.y / c2.y;
                temp.y = c1.z / c2.z;
                return temp;
            //}
                   
        }
       
        //
        // " * " opertor
        public static vector operator *(vector c1, vector c2)
        {
            vector temp = new vector();
            //if (c1.x||c2.x||c2.y||c2.y !=0){
                temp.x = c1.x * c2.x;
                temp.y = c1.y * c2.y;
                temp.z = c1.z * c2.z;
                return temp;
            //}
            /* else{
                temp.x=0;
                temp.y=0;
            } */
                
        }
        public void Display()
        {
            //if(x||y!=0){
                Console.WriteLine($"{x} x + {y} y + {z} z");
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
            vector c1 = new vector(3, 7, 6);
          
            vector c2 = new vector(5, 2, 4);
            
            vector c4 = c1 + c2;
            c4.Display();
            vector c5 = c1 - c2;
            c5.Display();
            vector c6 = c1 * c2;
            c6.Display();
            vector c7 = c1 / c2;
            c7.Display();
            
        }
    }
}

// Stage 3 will be simple user interface
