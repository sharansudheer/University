#include <bits/stdc++.h>
using namespace std;
struct node{
	int data; 
	struct node *prev;
	struct node *next;
}
struct node *head, *head1;
void beginsert(){
	struct node *ptr;
	int item;
	ptr = (struct node *) mallaoc(sizeof(struct node *));
	if(ptr == NULL){
		cout<<"Overflow"<<endl;
	}
	else{
		if(head==NULL){
			cout<<"Enter the item"<<endl;
			cin>>item;
			ptr->data=item;
			ptr->next=NULL;
			ptr->prev=NULL;
			head=ptr;
		}else
		{
			cout<<"Enter the item"<<endl;
			cin>>item;
			ptr->data=item;
			ptr->prev=NULL;
			ptr->next=head;
			head->prev=ptr;
			head=ptr;
		}		
			
	}
}
void endinsert(){
	struct node *ptr;
	int item;
	ptr = (struct node *) mallaoc(sizeof(struct node *));
	temp  = (struct node *) mallaoc(sizeof(struct node *));
	cout<<"Enter the item"<<endl;
	cin>>item;
	ptr->data=item;
	if(ptr == NULL){
		cout<<"Overflow"
	}
	else{
		if(head==NULL){
			ptr->prev=NULL;
			ptr->next=NULL;
			head=ptr;
		}else{
			temp = head;
			while(temp->next!=NULL){
				temp=temp->next;
			}
			temp->next=ptr;
			ptr->prev=temp;
			ptr->next=NULL;
		}
	}
}
		
	

int main(){
	int a;
	return 0;
}
