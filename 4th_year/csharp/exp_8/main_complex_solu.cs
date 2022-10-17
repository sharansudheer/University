//ES WIRD WIEDER PASSIEREN
using System;
using System.Threading;
class Program
{

    public void startthreads()
    {
        Console.WriteLine("1. Withdraw");
        Console.WriteLine("2. Deposit ");

        int key=int.Parse(Console.ReadLine());

        int bal;
        Console.WriteLine("Enter the amount to be deposited");
        int ama = int.Parse(Console.ReadLine());
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

    public void deposit(object mon)
    {
        Monitor.Enter(this);
        {
            int amt = Convert.ToInt32(mon);
            Console.WriteLine("{0} started", Thread.CurrentThread.Name);
            Console.WriteLine("Thread Priority:" + Thread.CurrentThread.Priority);
            Console.WriteLine("The amount to be deposited: ");
            
            this.bal = int.Parse(Console.ReadLine());
            amt = amt + this.bal;
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

/*
 
abstract class BaseThread
{
    private Thread _thread;

    protected BaseThread()
    {
        _thread = new Thread(new ThreadStart(this.RunThread));
    }

    // Thread methods / properties
    public void Start() => _thread.Start();
    public void Join() => _thread.Join();
    public bool IsAlive => _thread.IsAlive;

    // Override in base class
    public abstract void RunThread();
}

public MyThread : BaseThread
{
    public MyThread()
        : base()
    {
    }

    public override void RunThread()
    {
        // Do some stuff
    }
}

*/
