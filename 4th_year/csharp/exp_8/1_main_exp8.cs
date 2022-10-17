//ES WIRD WIEDER PASSIEREN
using System;
using System.Threading;
class Program
{
    int amt = 2500;
    public void startthreads()
    {
        Monitor.Enter(this);
        {

            Thread t1 = new Thread(new ThreadStart(withdrawal));
            t1.Name = "Withdraw Thread";
            t1.Start();
            Thread t2 = new Thread(new ThreadStart(deposit));
            t2.Name = "Deposit Thread";
            t2.Start();
            Thread t3 = new Thread(new ThreadStart(withdrawal));
            t3.Name = "Withdraw Thread";
            t3.Start();
        }
        Monitor.Exit(this); 

    }
    public void withdrawal()
    {
        Monitor.Enter(this);
        {
            
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
    public void deposit()
    {
        Monitor.Enter(this);
        {

            Console.WriteLine("{0} started", Thread.CurrentThread.Name);
            Console.WriteLine("Thread Priority:" + Thread.CurrentThread.Priority);
            Console.WriteLine("The amount to be Deposited ");
            int bal;
            bal = int.Parse(Console.ReadLine());
            amt = amt + bal;
            Console.WriteLine("The amount is {0}", amt);
            
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
