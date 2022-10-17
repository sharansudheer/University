//ES WIRD WIEDER PASSIEREN
using System;
using System.Threading;
class Program
{

    public void startthreads()
    {
        int ama = 1000;
        Console.WriteLine("Enter the amount to be deposited");
        Thread t1 = new Thread(new ParameterizedThreadStart(withdrawal));
        t1.Name = "Withdraw Thread";
        t1.Start(ama);
    }
    public void withdrawal(object mon)
    {
        Monitor.Enter(this);
        {
            int amt = Convert.ToInt32(mon);
            Console.WriteLine("{0} started", Thread.CurrentThread.Name);
            Console.WriteLine("Thread Priority:" + Thread.CurrentThread.Priority);
            Console.WriteLine("The amount to be withdrawn: ");
            int bal;
            bal = int.Parse(Console.ReadLine());
            if (bal > amt)
                Console.WriteLine("Not enough cash");
            else
            {
                amt = amt - bal;
                Console.WriteLine("The amount is {0}", amt);
            }
        }
        Console.ReadKey();
        Monitor.Exit(this);
    }
    static void Main(string[] args)

    {
        Console.WriteLine("Banking Application");
        Program p = new Program();
        p.startthreads();
        
    }
   
    
}
