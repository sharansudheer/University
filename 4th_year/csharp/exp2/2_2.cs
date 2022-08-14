//LIBRARY MANAGEMENT SYSTEM
using System;
using System.Collections.Generic;
public class library
{
  abstract class lib_mang
  {
    public void add_books(ref bname, bserial, libid){
        //test using arrays, impliment using list

    }
    public abstract void lend_books(ref lender_n, lender_id, lender_date);
    
    public abstract void change_name();
    public abstract void recieve_b(ref lender_n, lender_id, lender_date);
    // should delete the lender's name from the lender's list

    

    }

  }
  class fine : lib_mang{
    //cal fine for late return
     
    }
  
  class missing : lib_mang{
    
    //public override void 
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



  public static void Main (string[]args)
  {
    //sample to reengineer
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
