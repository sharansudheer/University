namespace exp_5main 
{ 
    class Program
    {
    static void Main(string[] args)
    {
            string str = "abcdefg";
            int length = str.Length;
            Console.WriteLine("3) The length of '{0}' is {1}", str, length);
            String original = "aaabbb";

            Console.WriteLine("The original string: '{0}'", original);
            String modified = original.Insert(3, " ");
            Console.WriteLine("The modified string: '{0}'", modified);
            // The example displays the following output:
            //     The original string: 'aaabbb'
            //     The modified string: 'aaa bbb'
            //public string Insert (int startIndex, string value);

            

            string MyString = "Hello Beautiful World!";
            Console.WriteLine(MyString.Remove(5, 10));
            //public string Remove (int startIndex, int count);
            // The example displays the following output:
            //         Hello World!

            //public string Replace (string oldValue, string? newValue);
            string errString = "This docment uses 3 other docments to docment the docmentation";

            Console.WriteLine("The original string is:{0}'{1}'{0}", Environment.NewLine, errString);

            // Correct the spelling of "document".

            string correctString = errString.Replace("docment", "document");

            Console.WriteLine("After correcting the string, the result is:{0}'{1}'",
                    Environment.NewLine, correctString);

            // This code example produces the following output:
            //
            // The original string is:
            // 'This docment uses 3 other docments to docment the docmentation'
            //
            // After correcting the string, the result is:
            // 'This document uses 3 other documents to document the documentation'
            //

            //public string ToUpper ();
            //public string ToLower ();

            string s = "You win some. You lose some.";

            string[] subs = s.Split(' ');

            foreach (var sub in subs)
            {
                Console.WriteLine($"Substring: {sub}");
            }

            // This example produces the following output:
            //
            // Substring: You
            // Substring: win
            // Substring: some.
            // Substring: You
            // Substring: lose
            // Substring: some.

            //public string[] Split(char[]? separator, int count);
            string name = "Alex Johnson III";

            string[] subs1 = name.Split(null, 2);

            string firstName = subs1[0];
            string lastName;
            if (subs.Length > 1)
            {
                lastName = subs[1];
            }

            // firstName = "Alex"
            // lastName = "Johnson III"

            string str1 = "GeeksforGeeks";
            string str2 = "GFG";
            str2 = String.Copy(str1);

            Console.WriteLine("Strings are str1 = "
            + "'{0}' and str2='{1}'", str1, str2);












            Console.ReadKey();
        }
    }
}
//
/*

#include <iostream>
#include <regex>
using namespace std;
 
// Function to remove uppercase characters
string removingUpperCaseCharacters(string str)
{
  // Create a regular expression
  const regex pattern("[A-Z]");
 
  // Replace every matched pattern with the
  // target string using regex_replace() method
  return regex_replace(str, pattern, "");
}
 
// Function to remove lowercase characters
string removingLowerCaseCharacters(string str)
{
  // Create a regular expression
  const regex pattern("[a-z]");
 
  // Replace every matched pattern with the
  // target string using regex_replace() method
  return regex_replace(str, pattern, "");
}
 
// Function to remove special characters
string removingSpecialCharacters(string str)
{
  // Create a regular expression
  const regex pattern("[^A-Za-z0-9]");
 
  // Replace every matched pattern with the
  // target string using regex_replace() method
  return regex_replace(str, pattern, "");
}
 
// Function to remove numeric characters
string removingNumericCharacters(string str)
{
  // Create a regular expression
  const regex pattern("[0-9]");
 
  // Replace every matched pattern with the
  // target string using regex_replace() method
  return regex_replace(str, pattern, "");
}
 
// Function to remove non-numeric characters
string removingNonNumericCharacters(string str)
{
  // Create a regular expression
  const regex pattern("[^0-9]");
 
  // Replace every matched pattern with the
  // target string using regex_replace() method
  return regex_replace(str, pattern, "");
}
 
int main()
{
  // Given String str
  string str = "GFGgfg123$%";
 
  // Print the strings after the simultaneous
  // modifications
  cout << "After removing uppercase characters: "
       << removingUpperCaseCharacters(str) << endl;
  cout << "After removing lowercase characters: "
       << removingLowerCaseCharacters(str) << endl;
  cout << "After removing special characters: "
       << removingSpecialCharacters(str) << endl;
  cout << "After removing numeric characters: "
       << removingNumericCharacters(str) << endl;
  cout << "After removing non-numeric characters: "
       << removingNonNumericCharacters(str) << endl;
 
  return 0;
}

 */
