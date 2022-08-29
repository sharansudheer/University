using System;
public class bank {
  public static void deposit(ref int main_balance){
    Console.WriteLine("Enter the amount");
    int dep = int.Parse(Console.ReadLine());
    main_balance += dep;
    Console.WriteLine("Deposit Sucessfull , Your main balance is "+main_balance);
  }
  public static void withdraw(ref int main_balance){
    Console.WriteLine("Enter the amount");
    int withd = int.Parse(Console.ReadLine());
    if (withd>main_balance){
        Console.WriteLine("Insufficient Balance");
    }
    else{
        main_balance -= withd;
        Console.WriteLine("Withdraw Successfull , Your main balance is : "+main_balance);
  }

  }
  public static void check_balance(ref int main_balance){
      Console.WriteLine("Balance : "+main_balance);
  }
  public static void Main(string[] args)
  {
    int main_balance=10000;
    Console.WriteLine("1.Deposit"+"\n");
    Console.WriteLine("2.Withdraw"+"\n");
    Console.WriteLine("3.Check Balance"+"\n");
    Console.WriteLine("4.Exit");
    int op;
    do{
    op = int.Parse(Console.ReadLine());
    if(op==1){
      bank.deposit(ref main_balance);
    }
    else if(op==2){
      bank.withdraw(ref main_balance);
    }
    else if(op==3){
     bank.check_balance(ref main_balance);
    }
    else if(op==4){
      break;
      }
    }
    while(op!=4);
  }
}
