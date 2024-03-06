#pragma once

// main inclusions
#include <iostream>
#include <vector>
#include <iomanip>

using namespace std;

vector<int> arrayInit(int size) {
	vector<int> temp(size);
	for (int i = 0; i < size; i++) temp[i] = rand() % 100 + 1;
	return temp;
}

void arrayPrint(vector<int> array) {
	cout << '[';
	for (int i = 0; i < array.size(); i++) { cout << array[i]; if (i != array.size() - 1) cout << ", "; }
	cout << "]\n";
}

void iteration(vector<int> array, int i, int j, int counter) {
	cout << "\n\t| ";
	for (int i = 0; i < array.size(); i++) { cout << array[i]; if (i != array.size() - 1) cout << ", "; }
	cout << left << setw(3) << " | " << setw(2) << i << " <-> " << setw(3) << j << "|";
}

vector<int> bubbleSort(vector<int> array) {
	int size = array.size(), counter = 0;
	cout << "\n| Итерации:\n\t ---------------------------------------------------";

	for (int i = 0; i < size - 1; i++) {
		for (int j = size - 1; j > i; j--) { if (array[j] < array[j - 1]) { swap(array[j], array[j - 1]); counter++; iteration(array, array[j], array[j - 1], counter); } }
	}

	cout << "\n\t ---------------------------------------------------\n\n| Количество подмен: " << counter << "\n";
	return array;
}

vector<int> sinkingSort(vector<int> array) {
	int size = array.size(), counter = 0;
	cout << "\n| Итерации:\n\t ---------------------------------------------------";

	for (int i = 0; i < size - 1; i++) {
		for (int j = size - 1; j > i; j--) { if (array[j] < array[j - 1]) { swap(array[j], array[j - 1]); counter++; iteration(array, array[j], array[j - 1], counter); } }
	}

	cout << "\n\t ---------------------------------------------------\n\n| Количество подмен: " << counter << "\n";
	return array;
}

vector<int> qSinkingSort(vector<int> array) {
	int size = array.size(), i = 0, counter = 0; bool flag = true;
	cout << "\n| Итерации:\n\t ---------------------------------------------------";

	while (flag) {
		flag = false;
		for (int j = size - 1; j > i; j--) if (array[j] < array[j - 1]) { 
			flag = true; counter++;
			swap(array[j], array[j - 1]); iteration(array, array[j], array[j - 1], counter);
		}
		i++;
	}

	cout << "\n\t ---------------------------------------------------\n\n| Количество подмен: " << counter << "\n";
	return array;
}

vector<int> shakerSort(vector<int> array) {
	bool flag = true; int size = array.size(), counter = 0, left = 0, right = size - 1;
	cout << "\n| Итерации:\n\t ---------------------------------------------------";

	while ((left < right) and flag) {
		flag = false;

		for (int i = left; i < right; i++) {
			if (array[i] > array[i + 1]) { flag = true; swap(array[i], array[i + 1]); counter++; iteration(array, array[i], array[i + 1], counter); }
		} right--;

		for (int j = right; j > left; j--) {
			if (array[j] < array[j - 1]) { flag = true; swap(array[j], array[j - 1]); counter++; iteration(array, array[j], array[j - 1], counter); }
		} left++;
	}

	cout << "\n\t ---------------------------------------------------\n\n| Количество подмен: " << counter << "\n";
	return array;
}