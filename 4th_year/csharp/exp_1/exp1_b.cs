using System;
class Cal1 {
  public static void Main() {
  Add(10,5);
  Mul(2,8,3);
  Sub(6,2);
  }
  public static void Add(params int[] list){
    int res=0;
    foreach(int i in list){
    res+=i;
    }
    Console.WriteLine("Sum is "+res);
    }
  public static void Mul(params int[] list){
    int res=1;
    foreach(int i in list){
    res*=i;
    }
    Console.WriteLine("Product is "+res);
    }
    public static void Sub(params int[] list){
    int res=list[0];
    for (int i = 1; i < list.Length; i++) {
    res-=list[i];
    }
    Console.WriteLine("Difference is "+res);
    }
}
