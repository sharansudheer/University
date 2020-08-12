#include <iostream>
using namespace std;

int main()
{
    int k,l,r,s;

    cout << "Enter number of rows: ";
    cin >> r;

    for(int i=1; i <= r; i++)
    {
        
        for(s = 1; s <= r-i; s++)
        {
            cout <<"  ";
		}
		for(k=1;k<=i;k++)    
		{    
			cout<<k<<" ";    
		}    
		for(l=i-1;l>=1;l--)    
		{    
			cout<<l<<" "; 
		}   
           
        
        
		cout << endl;
    }
    return 0;
}
