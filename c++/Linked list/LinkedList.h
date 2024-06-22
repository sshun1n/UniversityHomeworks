#pragma once
#include <iostream>
#include <vector>

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
	void AddNodeForward(int data);
	void InsertNode(int index, int data);
	void DeleteNode(int data);
	void DeleteIndex(int index);
	int Index(int data);
	void Clear();
	void Print();
};

List::List() {
	head = NULL;
	current = NULL;
	temp = NULL;
}

void List::AddNodeForward(int data) {
	nodePointer newNode = new node;
	newNode->data = data;

	if (head == NULL) { head = newNode; head->next = NULL; }
	else {
		newNode->next = head;
		head = newNode;
	}
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
	else head = newNode;
}

void List::InsertNode(int index, int data) {
	if (index == 0) {
		AddNodeForward(data); 
		return;
	}
	nodePointer newNode = new node;
	newNode->data = data;
	current = head;
	int i = 0;

	while (current != NULL and i < index - 1) {
		current = current->next;
		i++;
	}
	if (current == NULL) cout << "Индекс " << index << " не существует в списке.\n";
	else {
		newNode->next = current->next;
		current->next = newNode;
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

void List::DeleteIndex(int index) {
	nodePointer deletionPointer = NULL;
	current = head;
	temp = head;
	int i = 0;

	while (current != NULL and i < index) {
		temp = current;
		current = current->next;
		i++;
	}
	if (current == NULL) cout << index << " не существует в списке\n";
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

int List::Index(int data) {
	current = head;
	int i = 0;

	while (current != NULL and current->data != data) {
		current = current->next;
		i++;
	}
	if (current == NULL) cout << data << " не существует в списке\n";
	else return i;
}

void List::Clear() {
	current = head;
	temp = head;

	while (current != NULL) {
		temp = current;
		current = current->next;

		delete temp;
	}

	head = NULL;
}

void List::Print() {
	current = head;

	if (head == NULL) { cout << "Список пуст\n"; return; }
	while (current != NULL) {
		cout << current->data << " ";
		current = current->next;
	} cout << endl;
}