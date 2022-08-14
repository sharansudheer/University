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
      // using ref main_bal for testing
      // use accno to get the main balance but how to get the list as a var
      Console.WriteLine("Enter the amount");
      int withd = int.Parse(Console.ReadLine());
      if (withd>main_balance){
      Console.WriteLine("Insufficient Balance");
      }else{
      main_balance -= withd;
      Console.WriteLine("Withdraw Successfull , Your main balance is : "+main_balance); 
    }
    public void credit(){
      Console.WriteLine ("Enter the amount");
      int dep = int.Parse (Console.ReadLine ());
      main_balance += dep;
      Console.WriteLine ("Deposit Sucessfull , Your main balance is " +
        main_balance);
    }
    public abstract void change_name();
    public abstract void createacc ();
    

    }

  }
  class savings_acc : account{
    //cal bank interest 2.5% for deposit above 50,000
      public override void credit(ref main_balance){
      Console.WriteLine ("Enter the amount");
      int dep = int.Parse (Console.ReadLine ());
      main_balance += dep;
      Console.WriteLine ("Deposit Sucessfull , Your main balance is " +
        main_balance);
    }
  }
  class current_acc : account{
    //cal 2.5% bank charge for withdrawal above 100,000
    //using ref main balance for testing
    public override void debit(ref main_balance)
    { 
      // use accno to get the main balance but how to get the list as a var
      Console.WriteLine("Enter the amount");
      int withd = int.Parse(Console.ReadLine());
      withd *= 2.5;
      if (withd>main_balance){
      Console.WriteLine("Insufficient Balance");
      }else{
      main_balance -= withd;
      Console.WriteLine("Withdraw Successfull , Your main balance is : "+main_balance); 
    }
  }

  sealed class manager : account{
    public override void change_name(){
      /*
      public static List<Products> list = new List<Products>()

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
      int accno=1009;
      int pin=9900;
      List<customer> customers = new List<customer>
      {
        new customer {name,accno,actype,main_balance=0, pin}
      };

    }

  }


  public static void Main (string[]args)
  {
    int main_balance = 10000;
    Console.WriteLine ("Enter Name");
    string  name = Console.ReadLine();

    Console.WriteLine ("Enter your code");
    int code = int.Parse(Console.ReadLine());
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
