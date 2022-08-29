//operator overloading Oppenheimer
using System;
namespace OperatorOverloading
{
    public class money
    {
        private int rupees;
        private int paise;
        public money(int r = 0, int i = 0)
        {
            rupees = r;
            paise = i;
        }
        //
        // + opertor overloading
        public static money operator +(money c1, money c2)
        {
            money temp = new money();
            int goat=c1.paise+c2.paise;
            if (goat>=100){
                temp.rupees = c1.rupees + c2.rupees + (goat/100);
                temp.paise = (goat-((goat/100)*100));
            }       
            else{
                temp.rupees = c1.rupees + c2.rupees;
                temp.paise = c1.paise + c2.paise;
            }
            return temp;
        }
        
        
        public void Display()
        {
            //if(rupees||paise!=0){
                Console.WriteLine($"{rupees} rupees + {paise} paise");
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
            int r1,r2,p1,p2;
            Console.WriteLine("Enter the rupees and paise for set 1");
            r1 = int.Parse (Console.ReadLine ());
            p1 = int.Parse (Console.ReadLine ());
            Console.WriteLine("Enter the rupees and paise for set 2");
            r2 = int.Parse (Console.ReadLine ());
            p2 = int.Parse (Console.ReadLine ());
            money c1 = new money(r1, p1);
          
            money c2 = new money(r2, p2);
            
            money c4 = c1 + c2;
            c4.Display();
            
        }
    }
}

    
