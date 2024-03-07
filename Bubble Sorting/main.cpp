// main inclusions
#include <iostream>
#include <vector>
#include <fstream>

// headers
#include "functions.h"
#include "quicksort.h"

using namespace std;

int main() {
	setlocale(LC_ALL, "RU"); system("chcp 1251"); system("cls");
	int function;
	cout << "[1] Пузырьковая сортировка\n[2] Сортировка погружения\n[3] Оптимизированный пузырёк\n[4] Шейкерная сортировка\n[5] Быстрая сортировка\n\nВвод: "; cin >> function; system("cls");

	if (function != 0) {
		int size; cout << "Введите размерность массива: "; cin >> size; system("cls");
		vector<int> array = arrayInit(size); cout << "| Исходный массив:\n\t"; arrayPrint(array);

		if (function == 1) array = bubbleSort(array);
		if (function == 2) array = sinkingSort(array);
		if (function == 3) array = qSinkingSort(array);
		if (function == 4) array = shakerSort(array);
		if (function == 5) myQuickSort(array, 0, size - 1);

		cout << "\n\n| Обработанный массив:\n\t"; arrayPrint(array);
	}

	cout << '\n'; system("pause"); main();
	return 0;
}