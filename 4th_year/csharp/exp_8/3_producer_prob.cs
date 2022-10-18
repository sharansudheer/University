//"Das Leben ist am Ende nur eine Ansammlung von verpassten Chancen."

using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

class MainClass
{
    static void Main(string[] args)
        throw new ThreadInterruptedException();
    {
        
        sealed Producer prod = new Producer();

    Thread t1 = new Thread(new Runnable() {
            @Override
            public void run()
    {
        try
        {
            pc.produce();
        }
        catch (InterruptedException e)
        {
            e.printStackTrace();
        }
    }
});

// Create consumer thread
Thread t2 = new Thread(new Runnable() {
            @Override
            public void run()
{
    try
    {
        pc.consume();
    }
    catch (InterruptedException e)
    {
        e.printStackTrace();
    }
}
        });

// Start both threads
t1.start();
t2.start();

// t1 finishes before t2
t1.join();
t2.join();
    }






public static class Producer
{
    LinkedList<int> list = new LinkedList<int>();
    int capacity = 2;
    public void produce() throws InterruptedException
    {

        while (true) {
                synchronized(this)
        {
            // producer thread waits while list
            // is full
            while (list.size() == capacity)
                wait();

            System.out.println("Producer produced-"
                               + value);

            // to insert the jobs in the list
            list.add(value++);

            // notifies the consumer thread that
            // now it can start consuming
            notify();

            // makes the working of program easier
            // to  understand
            Thread.sleep(1000);
        }
    }
}

// Function called by consumer thread
public void consume() throws InterruptedException
{
            while (true) {
        synchronized(this)
                {
            // consumer thread waits while list
            // is empty
            while (list.size() == 0)
                wait();

            // to retrieve the first job in the list
            int val = list.removeFirst();

            System.out.println("Consumer consumed-"
                               + val);

            // Wake up producer thread
            notify();

            // and sleep
            Thread.sleep(1000);
        }
    }
}
