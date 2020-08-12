#include <iostream>
#include <string>
using namespace std;
int main(){
	string a,b;
	cout<<"Enter the string"<<endl;
	cin>>a;
	int n= a.length();
		
	for(int i=n-1; i>=0; i--){
		b.push_back(a[i]); // to insert the last charecter from the string the user inputed to the first postion of the refference string. Stack method
		
		}
	int count=0;
	for(int i=0; i<n; i++){
		 if (a[i] != b[i]) { 
            count ++; // if a charecter is found not to be equal to the string inputed,it returns 1
            break; 
		}
	}
	if(count==0){
		cout<<"Palindrom";
	}
	else{
		cout<<"Not palindrom";
	}
	
	
	return 0;
}

