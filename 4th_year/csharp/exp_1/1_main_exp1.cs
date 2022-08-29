//Bhaskara, Where are you. Joji, why are you fishing in a fishlesss pond
using System;
public class Calculator
{
  public static int add(int x,int y,int z){
    return x+y+z;
  }
  public static int sub(int x,int y,int z){
    return x-y-z;
  }
  public static int mul(int x,int y,int z){
    return x*y*z;
  }
  public static void Main(string[] args)
{
    Console.WriteLine("Enter the first number:");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the second number:");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the third number:");
    int c = int.Parse(Console.ReadLine());
    int ans1 = add(a,b,c);
    int ans2 = sub(a,b,c);
    int ans3 = mul(a,b,c);
    Console.WriteLine("Addition:");
    Console.WriteLine(ans1);
    Console.WriteLine("Subtraction");
    Console.WriteLine(ans2);
    Console.WriteLine("Multiplication");
    Console.WriteLine(ans3);
    }
}
