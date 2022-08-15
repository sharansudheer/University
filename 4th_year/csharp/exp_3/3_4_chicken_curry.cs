//operator overloading Oppenheimer
using System;
namespace OperatorOverloading
{
    public struct Price
{
    public float Amount;
    public string CurrencyCode;
    public float ExchangeRateWRTUSD;
    public Price(float fAmount, string sCurrencyCode,
             float fExchangeRateWRTUSD)
{
    this.Amount = fAmount;
    this.CurrencyCode=sCurrencyCode;
    this.ExchangeRateWRTUSD = fExchangeRateWRTUSD;
}
public static Price operator +(Price p1, Price p2)
{
Price p3;
//Convert both currencies to a base currency
float p1InUSD = p1.Amount * p1.ExchangeRateWRTUSD;
float p2InUSD = p2.Amount * p2.ExchangeRateWRTUSD;

// Add the two prices in the base currency
// Convert the result to the first currency type
float p3Converted = (p1InUSD + p2InUSD) /
                      p1.ExchangeRateWRTUSD;
p3 = new Price(p3Converted,
            p1.CurrencyCode,
            p1.ExchangeRateWRTUSD);
            if (p1.ExchangeRateWRTUSD ==
     p2.ExchangeRateWRTUSD)
{
    p3 = new Price(p1.Amount+p2.Amount,
           p1.CurrencyCode,
           p1.ExchangeRateWRTUSD);
}
else
{
//Convert both currencies to a base currency

}
}

return p3;
}
public static void Main (string[]args){
    Price keyboardPrice =
   new Price(40,"AUS",(float).6);

Price mousePrice =
   new Price(20, "EUR", (float).8);

Price Total = keyboardPrice + mousePrice;

MessageBox.Show("Total Order Price is: " +
   Total.Amount.ToString());
}
}



