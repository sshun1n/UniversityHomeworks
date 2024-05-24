#include "myLinkedList.h"

using namespace std;

int main() {
	setlocale(LC_ALL, "RU"); system("chcp 1251"); system("cls");

	List list;

	for (int i = 0; i < 10; i++) list.AddNode(i);

	list.DeleteNode(0);
	list.Print();
	
	return 0;
}