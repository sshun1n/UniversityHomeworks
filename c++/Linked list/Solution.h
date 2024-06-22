#pragma once
#include <iostream>
#include "LinkedList.h"
#include <vector>

vector<int> randArray(int size) {
	vector<int> array(size);
	for (int i = 0; i < size; i++) array[i] = rand() % 100 + 1;
	return array;
}

List fromArrToList(vector<int> randArray) {
	List list;
	for (int i = 0; i < randArray.size(); i++) list.AddNode(randArray[i]);
	return list;
}

List InputList(int size) {
	List list;
	int data;

	for (int i = 0; i < size; i++) {
		cout << '[' << i << "] -> "; cin >> data;
		list.AddNode(data);
	}

	return list;
}

void MainMenu(List& list) {
	system("cls"); cout << "Текущий список:\n"; list.Print();
	int func;

	cout << "\n[1] Добавить элемент в начало списка\n[2] Добавить элемент в конец списка\n[3] Добавить элемент в определённую позицию\n[4] Удалить элемент по его значению\n[5] Удалить элемент по его пизиции\n[6] Поиск номера по значению\n[7] Очистить список\n\nВвод: "; cin >> func; system("cls");

	if (func == 1) { int data; cout << "Введите значение элемента: "; cin >> data; list.AddNodeForward(data); }
	if (func == 2) { int data; cout << "Введите значение элемента: "; cin >> data; list.AddNode(data); }
	if (func == 3) { int data, index; list.Print(); cout << "\nВведите позицию для вставки: "; cin >> index; cout << "Введите значение элемента: "; cin >> data; list.InsertNode(index, data); }
	if (func == 4) { int data; cout << "Введите значение элемента: "; cin >> data; list.DeleteNode(data); }
	if (func == 5) { int index; cout << "Введите позицию элемента: "; cin >> index; list.DeleteIndex(index); }
	if (func == 6) { int data; list.Print(); cout << "Введите значение элемента: "; cin >> data; cout << list.Index(data) << "\n"; system("pause"); }
	if (func == 7) { list.Clear(); }

	MainMenu(list);
}