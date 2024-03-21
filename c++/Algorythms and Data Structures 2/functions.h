#pragma once

// main inslusions
#include <iostream>
#include <vector>

using namespace std;

int* InputArray(int iter) {
	int* array = new int[iter]; system("cls");

	for (int i = 0; i < iter; i++) { cout << "[" << i + 1 << "] -> "; cin >> array[i]; } system("cls");

	return array;
}

vector<int> InputArray(float iter) {
	vector<int> array(iter); system("cls");

	for (int i = 0; i < iter; i++) { cout << "[" << i + 1 << "] -> "; cin >> array[i]; } system("cls");

	return array;
}

int* InputArrayAuto(int iter) {
	int* array = new int[iter];

	for (int i = 0; i < iter; i++) array[i] = i;

	return array;
}

int Search(int* array, int temp, int iter) {

	for (int i = 0; i < iter; i++) { if (array[i] == temp) { return i; } } system("pause");

}

int BarierSearch(int* array, int iter, int temp) {

	if (array[iter - 1] == temp) return iter - 1;

	int last_item = array[iter - 1], i = 0; array[iter - 1] = temp;

	while (array[i] != temp) i++;

	array[iter - 1] = last_item;

	if (i < temp - 1) return i;

	return -1;
}

void Print(int* array, int iter) {

	cout << "Исходный массив:\n";
	for (int i = 0; i < iter; i++) { cout << array[i]; if (i != iter - 1) { cout << ", "; } }

}

void Print(vector<int> array) {
	int iter = array.size();
	
	cout << "Исходный массив:\n";
	for (int i = 0; i < iter; i++) { cout << array[i]; if (i != iter - 1) { cout << ", "; } }
}

int BinarySearch(int* array, int left, int right, int temp) {
	int i = (left + right) / 2;
	
	if (right < left) return -1;
	if (array[i] == temp) return i;
	if (array[i] > temp) return BinarySearch(array, left, i - 1, temp);

	return BinarySearch(array, i + 1, right, temp);
}

int IndexBinarySearch(int* array, int left, int right, int temp) {

	int counter = 0;
	while (left <= right) {
		int i = (left + right) / 2; counter++;

		if (array[i] == temp) return counter;
		if (array[i] > temp) right = i - 1;
		else left = i + 1;
	}

	return counter;
}

int findMissingItem(vector<int> arr) {
	int size = arr.size() + 1;
	int summ = size * (size + 1) / 2;
	int current_sum = 0;

	for (int i = 0; i < arr.size(); i++) current_sum += arr[i];

	return summ - current_sum;
}