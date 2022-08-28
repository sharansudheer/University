using System;
namespace Exp2try
{
    public class Account
    {
        public string name;
        public int accnum;
        public int balance = 0;
        public Account(string n, int an)
        {
            name = n;
            accnum = an;
        }
    }
    abstract class account {
        public abstract void changename(string nmm1);
        public abstract void credit(int n);
        public abstract void debit(int m);
        public abstract void display(string nam, int bal);
        public abstract void calculatebankcharge(int bal11);

    }
    class savingsAccount : Account
    {
        public string namee;
        public int acc_num;
        public savingsAccount(string namee, int acc_num) : base(namee, acc_num)
        {
            this.namee = namee;
            this.acc_num = acc_num;
        }
    }
    public class currentAccount : Account
    {
        public string namee;
        public int acc_num;
        public int min_balance;
        public currentAccount(string namee, int acc_num, int min_balance) : base(namee, acc_num)
        {
            this.namee = namee;
            this.acc_num = acc_num;
            this.min_balance = 1000;
        }
    }
    sealed class manager : account
    {
        public override void changename(string nm1)
        {
            Console.WriteLine("Name changed Successfully");
            Console.WriteLine("Your name is changed to " + nm1 + " !!");
        }

        public override void credit(int nn)
        {
            Console.WriteLine("Your current balance is " + nn + " !!");
        }

        public override void debit(int mm)
        {
            Console.WriteLine("Your current balance is " + mm + " !!");
        }

        public override void display(string nam, int bal)
        {
            Console.WriteLine("Welcome " + nam + " !!");
            Console.WriteLine("Your current balance is " + bal + " !!");
        }
        public override void calculatebankcharge(int bal1)
        {
            double sum = 0;
            if (bal1 <= 500)
            {
                sum = 10;
            }
            else if (bal1 > 500 && bal1 < 5000)
            {
                sum = 10 + (2 * (bal1 - 500) / 100);
            }
            else if (bal1 >= 5000 && bal1 <= 10000)
            {
                sum = 19.98 + (1 * (bal1 - 999) / 100);
            }
            Console.WriteLine(sum);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu\n1.Create Account\n2.Depostit\n3.Withdraw\n4.Balance Enquiry\n5.Change Name\n6.Calculate Charge\n7.Exit");
            savingsAccount[] acc = new savingsAccount[20];
            int accs = 0;
            int stat = 0;
            while (stat == 0)
            {
                Console.WriteLine("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        accs += 1;
                        Console.WriteLine("Enter your name: ");
                        string name = Console.ReadLine();
                        acc[accs] = new savingsAccount(name, accs);
                        Console.WriteLine("Account Created successfully..\nYour Account number is " + (accs));
                        break;
                    case 2:
                        Console.WriteLine("Welcome to Canara Bank");
                        Console.WriteLine("Enter your account number : ");
                        int num = int.Parse(Console.ReadLine());
                        Console.WriteLine("Welcome " + acc[num].name + " !!");
                        Console.WriteLine("Enter the amount you wish to deposit : ");
                        int am = int.Parse(Console.ReadLine());
                        manager obj = new manager();
                        if(acc[num].balance+am>10000)
                        {
                            Console.WriteLine("Maximum limit is 10000!!");
                        }
                        else
                        {
                            acc[num].balance += am;
                            obj.credit(acc[num].balance);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Welcome to  Bank");
                        Console.WriteLine("Enter your account number : ");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Welcome " + acc[n1].name + " !!");
                        Console.WriteLine("Enter the amount you wish to withdraw : ");
                        int am1 = int.Parse(Console.ReadLine());
                        if (am1 > acc[n1].balance)
                        {
                            Console.WriteLine("Insufficient funds");
                        }
                        else
                        {
                            acc[n1].balance -= am1;
                            manager obj1 = new manager();
                            obj1.debit(acc[n1].balance);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter your account number : ");
                        int n2 = int.Parse(Console.ReadLine());
                        if (n2 < 1 || n2 > accs)
                        {
                            Console.WriteLine("Invalid Account Number");
                        }
                        else
                        {
                            manager obj2 = new manager();
                            obj2.display(acc[n2].name, acc[n2].balance);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter your account number : ");
                        int n4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new name : ");
                        string nmm = Console.ReadLine();
                        acc[n4].name = nmm;
                        manager obj3 = new manager();
                        obj3.changename(acc[n4].name);
                        break;
                    case 6:
                         Console.WriteLine("Enter your account number : ");
                         int n5 = int.Parse(Console.ReadLine());
                         manager obj4 = new manager();
                         obj4.calculatebankcharge(acc[n5].balance);
                         break;
                    case 7:
                        Console.WriteLine("See you again !!");
                        stat = 1;
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Choose a valid option!!");
                        break;

                }
            }
        }
    }
}
