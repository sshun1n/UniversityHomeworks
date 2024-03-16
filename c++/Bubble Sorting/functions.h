#pragma once

// main inclusions
#include <iostream>
#include <vector>
#include <iomanip>
#include <fstream>

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

vector<int> selectionSort(vector<int> array) {
	int size = array.size(), counter = 0;
	cout << "\n| Итерации:\n";

	for (int i = 0; i < size - 1; i++) {
		int temp = i;

		for (int j = i + 1; j < size; j++) if (array[j] < array[temp]) { temp = j; }

		iteration(array, array[i], array[temp], 0); swap(array[i], array[temp]); counter++;
	}

	cout << "\n\n| Количество подмен: " << counter << "\n";
	return array;
}

vector<int> insertionSort(vector<int> array) {
	int size = array.size(), counter = 0, i, key, j;
	cout << "\n| Итерации:\n";
	
	for (i = 1; i < size; i++) {
		key = array[i]; j = i - 1;

		while (j >= 0 and array[j] > key) { array[j + 1] = array[j]; j--; }

		array[j + 1] = key; counter++; iteration(array, 0, 0, 0);
	}

	cout << "\n\n| Количество подмен: " << counter << "\n";
	return array;
}

vector<int> bubbleSort(vector<int> array) {
	int size = array.size(), counter = 0;
	cout << "\n| Итерации:\n";

	for (int i = 0; i < size; i++) {
		for (int j = 1; j < size - i; j++) { if (array[j] < array[j - 1]) { swap(array[j], array[j - 1]); counter++; iteration(array, array[j], array[j - 1], counter); } }
	}

	cout << "\n\n| Количество подмен: " << counter << "\n";
	return array;
}

vector<int> sinkingSort(vector<int> array) {
	int size = array.size(), counter = 0;
	cout << "\n| Итерации:\n";

	for (int i = 0; i < size - 1; i++) {
		for (int j = size - 1; j > i; j--) { if (array[j] < array[j - 1]) { swap(array[j], array[j - 1]); counter++; iteration(array, array[j], array[j - 1], counter); } }
	}

	cout << "\n\n| Количество подмен: " << counter << "\n";
	return array;
}

vector<int> qSinkingSort(vector<int> array) {
	int size = array.size(), i = 0, counter = 0; bool flag = true;
	cout << "\n| Итерации:\n";

	while (flag) {
		flag = false;
		for (int j = size - 1; j > i; j--) if (array[j] < array[j - 1]) { 
			flag = true; counter++;
			swap(array[j], array[j - 1]); iteration(array, array[j], array[j - 1], counter);
		}
		i++;
	}

	cout << "\n\n| Количество подмен: " << counter << "\n";
	return array;
}

vector<int> shakerSort(vector<int> array) {
	bool flag = true; int size = array.size(), counter = 0, left = 0, right = size - 1;
	cout << "\n| Итерации:\n";

	while ((left < right) and flag) {
		flag = false;

		for (int i = left; i < right; i++) {
			if (array[i] > array[i + 1]) { flag = true; swap(array[i], array[i + 1]); counter++; iteration(array, array[i], array[i + 1], counter); }
		} right--;

		for (int j = right; j > left; j--) {
			if (array[j] < array[j - 1]) { flag = true; swap(array[j], array[j - 1]); counter++; iteration(array, array[j], array[j - 1], counter); }
		} left++;
	}

	cout << "\n\n| Количество подмен: " << counter << "\n";
	return array;
}

void analytics() {
	ofstream file("table.csv");
	
	file << "bubble sort\nx; y\n";
	for (int i = 3; i < 17; i++) {
		int num = pow(2, i);
		vector<int> array = arrayInit(num);
		int size = array.size(), counter = 0;

		for (int i = 0; i < size - 1; i++) {
			for (int j = size - 1; j > i; j--) { if (array[j] < array[j - 1]) { swap(array[j], array[j - 1]); counter++; } }
		}

		file << num << "; " << counter << "\n";
	}

	file << "\nsinking sort\nx; y\n";
	for (int i = 3; i < 17; i++) {
		int num = pow(2, i);
		vector<int> array = arrayInit(num);
		int size = array.size(), counter = 0;

		for (int i = 0; i < size - 1; i++) {
			for (int j = size - 1; j > i; j--) { if (array[j] < array[j - 1]) { swap(array[j], array[j - 1]); counter++; } }
		}

		file << num << "; " << counter << "\n";
	}

	file << "\nshaker sort\nx; y\n";
	for (int i = 3; i < 17; i++) {
		int num = pow(2, i); bool flag = true;
		vector<int> array = arrayInit(num);
		int size = array.size(), counter = 0, left = 0, right = size - 1;;

		while ((left < right) and flag) {
			flag = false;

			for (int i = left; i < right; i++) {
				if (array[i] > array[i + 1]) { flag = true; swap(array[i], array[i + 1]); counter++; }
			} right--;

			for (int j = right; j > left; j--) {
				if (array[j] < array[j - 1]) { flag = true; swap(array[j], array[j - 1]); counter++; }
			} left++;
		}

		file << num << "; " << counter << "\n";
	}

	file.close();
}
