#include <iostream>
int bill(int a){
	if(0<a && a<101){
		return a*1.05;
		
	}
	else if(100<a && a<301){
		return a*2.35;
		
	}else if(300<a && a<501){
		return a*3.50;
		
	}else{
		return a * 4.20;
	}
	
}
using namespace std;
int main()
{
	int a;
	cout<<"Enter the units"<<endl;
	cin>>a;
	cout<<"Amount: "<<bill(a);	
	return 0;
}
