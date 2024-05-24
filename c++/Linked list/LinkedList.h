#pragma once
#include <iostream>

using namespace std;

class List {
private:
	typedef struct node {
		int data;
		node* next;
	}* nodePointer;

	nodePointer head;
	nodePointer current;
	nodePointer temp;

public:
	List();
	void AddNode(int data);
	void DeleteNode(int data);
	void Print();

};

List::List() {
	head = NULL;
	current = NULL;
	temp = NULL;
}

void List::AddNode(int data) {
	nodePointer newNode = new node;
	newNode->next = NULL;
	newNode->data = data;

	if (head != NULL) {
		current = head;
		while (current->next != NULL) current = current->next;
		current->next = newNode;
	}
	else {
		head = newNode;
	}
}

void List::DeleteNode(int data) {
	nodePointer deletionPointer = NULL;
	temp = head;
	current = head;

	while (current != NULL and current->data != data) {
		temp = current;
		current = current->next;
	}
	if (current == NULL) cout << data << " не существует в списке\n";
	else {
		deletionPointer = current;
		current = current->next;
		temp->next = current;

		if (deletionPointer == head) {
			head = head->next;
			temp = NULL;
		}

		delete deletionPointer;
	}
}

void List::Print() {
	current = head;

	while (current != NULL) {
		cout << current->data << " ";
		current = current->next;
	} cout << endl;
}