//MAIN BANK PROGRAM BUT NOT WORKING
using System;
using System.Collections.Generic;
public class bank
{
  abstract class account
  {
    public void cal_bankch(ref main_balance){

    }
    public void debit(ref main_balance)
    { 
       
    }
    public void credit(){
     
    }
    public abstract void change_name();
    public abstract void createacc ();
    

    }

  }
  class savings_acc : account{
    //cal bank interest 2.5% for deposit above 50,000
     
    }
  }
  class current_acc : account{
    
    public override void debit(ref main_balance)
    { 
      
      
    }
  }

  sealed class manager : account{
    public override void change_name(){
      /*
      int accno=1009;
      int pin=9900;
      List<customer> customers = new List<customer>
      {
        new customer {name,accno,actype,main_balance=0, pin}
      };
     List<Products> list = new List<Products>()

{

    new Products{ProductID=1, ProductName=“Chai”},

    new Products{ProductID=3, ProductName=“Aniseed Syrup”},

    new Products{ProductID=2, ProductName=“Chang”}

};

Update the ProductName with ProductID is equal to 2.

Public static void UpdateList()

{

    var result = from r in list where r.ProductID == 2 select r;

    result.First().ProductName = “Chan”; 
      */

    }
    public override void createacc (ref name, actype){
    }

  }


  public static void Main (string[]args)
  {
    
    savings_acc ob = new savings_acc();
    current_acc ob2 = new current_acc();
    
    do
      {
        Console.WriteLine ("1.Deposit" + "\n");
        Console.WriteLine ("2.Withdraw" + "\n");
        Console.WriteLine ("3.Check Balance" + "\n");
        Console.WriteLine ("4.Exit");
        int op;
        op = int.Parse (Console.ReadLine ());
        if (op>4){
           Console.WriteLine ("Invaild Input");
        }
        else{
           switch (op)          
            {
            case 1:
                bank.deposit (ref main_balance);
            case 2:
                bank.withdraw (ref main_balance);
            case 3:
                bank.check_balance (ref main_balance);
                break;        
            case 4:
                Console.WriteLine ("Thank You for Using this Application");
                Exit;
            }
        }     
    } while (op!=4);
         
  }  
}




/*
//FOOKING BAASTARD OF CUSTARD
//need to use delegate, Billgates or something to connect the CNS
using System;
using System.Collections.Generic;
namespace Student{
    public class data{
        private string name,accno,acctype;
        private int main_balance=0, pin;
        public string getData(){
            return this.name + this.accno + this.acctype + this.main_balance + this.pin;
        }
    }
    public class bank{
        
        public void details(ref na,acno,acty){
            List<data> bonk = new List<data>;
            bonk.Add(new data());
            bonk[0].name=na;
            bonk[0].accno=acno;
            bonk[0].acctype=acty;
            bonk[0].main_balance=0;
            bonk[0].pin=7890;
            foreach (data bata in bonk){
                Console.WriteLine(bata.getData());
            }
        }
    }
  static void Main() {
    Console.WriteLine("Hello World");
    
    string na= "Gigi Hadid";
    string acno = "123rrt2";
    string acty = "savings";
  
  }
}
*/
