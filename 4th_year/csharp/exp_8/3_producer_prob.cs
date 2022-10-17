//inital commit
using System;
using System.Threading;

public class MyData
{
    private double _pi = 0.0;
    private int _iterations = 0;
    private bool _valueReady = false;

    public void WriteData(int iterations, double val)
    {
        lock (this)
        {
            if (_valueReady)
            {
                Monitor.Wait(this);
            }
            _pi = val;
            _iterations = iterations;
            _valueReady = true;
            Monitor.Pulse(this);
        }
    }

    public void ReadData(out int iterations, out double val)
    {
        lock (this)
        {
            if (!_valueReady)
            {
                Monitor.Wait(this);
            }
            val = _pi;
            iterations = _iterations;
            _valueReady = false;
            Monitor.Pulse(this);
        }
    }
}

class MyProducer
{
    private MyData _pi;
    private int TotalIters;

    public MyProducer(MyData pi, int iterations)
    {
        _pi = pi;
        TotalIters = iterations;
    }

    public Thread CreateProducerThread()
    {
        return new Thread(new ThreadStart(this.calculate));
    }
    private void calculate()
    {
        int iters = 1;
        do
        {
            iters += 4;
            _pi.WriteData(iters, iters * 4);
        } while (iters < TotalIters);
    }
}

class MyConsumer
{
    private MyData _pi;
    private int TotalIters;

    public MyConsumer(MyData pi, int iterations)
    {
        _pi = pi;
        TotalIters = iterations;
    }

    public Thread CreateConsumerThread()
    {
        return new Thread(new ThreadStart(this.printValues));
    }

    private void printValues()
    {
        int iters = new int();
        double pi = new double();
        do
        {
            _pi.ReadData(out iters, out pi);
            System.Console.WriteLine("Iters: {0}\tPi:  {1}", iters.ToString(), pi.ToString());
        } while (iters < TotalIters);
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        MyData pi = new MyData();
        MyProducer prod = new MyProducer(pi, 100000);
        Thread producerThread = prod.CreateProducerThread();
        MyConsumer cons = new MyConsumer(pi, 100000);
        Thread consumerThread = cons.CreateConsumerThread();
        producerThread.Start();
        consumerThread.Start();

        producerThread.Join();
        consumerThread.Join();
    }
}
