#include <iostream>
using namespace std;
int calcu(int a,int b,int c){
	switch(a)
	{
		case 1:
			return c+b;
			break;
		case 2:
			return b-c;
			break;
		case 3:
			if(b==0)
			{
				cout<<"Zero divison not possible"<<endl;
				break;			
			}
			else{
				return b/c;
			}break;
		case 4:
			return b*c;
		case 5:
			return b % c;
			break;
		case 6:
			cout<<"Thank you"<<endl;
			return false;
			break;
		default:
			cout<<"Invalid input"<<endl;	
		}
		return 0;			
	
}


int main()
{
	int a,b,c;
	while(true){
		cout<<endl<<"Enter the digit of the options"<<endl<<"1.Add"<<endl<<"2.Subtract"<<endl<<"3.Divide"<<endl<<"4.Multiply"<<endl<<"5.Remainder"<<endl<<"6.Exit"<<endl;
		cin>>a;
		if(a==6){
			calcu(a,0,0);
			return false;
		}
		else{
			cout<<"Enter the 2 digits"<<endl;
			cin>>b>>c;
			cout<<"Result: "<<calcu(a,b,c);
		}
	}
	return 0;
}
