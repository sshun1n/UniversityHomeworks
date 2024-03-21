
// main inclusions
#include <iostream>
#include <fstream>

// headers
#include "functions.h"

using namespace std;

int main() {
	setlocale(LC_ALL, "RU"); system("chcp 1251"); system("cls");
	int iter, temp, function;

	cout << "Введите размерность массива: "; cin >> iter; int* array = InputArray(iter);

	cout << "[1] Последовательный поиск\n[2] Поиск с барьером\n[3] Бинарный поиск\n[4] Оценка работы бинарного поиска\n[5] Поиск пропущенного эл-а\n\nВвод: "; cin >> function; system("cls");

	if (function == 1) { Print(array, iter); cout << "\n\nВведите элемент для поиска : "; cin >> temp; cout << "ID искомого элемента: " << Search(array, temp, iter) << '\n'; }

	if (function == 2) { Print(array, iter); cout << "\n\nВведите элемент для поиска : "; cin >> temp; cout << "ID искомого элемента: " << BarierSearch(array, temp, iter) << '\n'; }

	if (function == 3) { 
		int subFunction;

		cout << "[1] Рекурсионный метод\n[2] Индексиальный метод\n\nВвод: "; cin >> subFunction; system("cls");

		if (subFunction == 1) { Print(array, iter); cout << "\n\nВведите элемент для поиска : "; cin >> temp; cout << "ID искомого элемента: " << BinarySearch(array, 0, iter, temp) << '\n'; }

		if (subFunction == 2) { Print(array, iter); cout << "\n\nВведите элемент для поиска : "; cin >> temp; cout << "ID искомого элемента: " << IndexBinarySearch(array, 0, iter, temp) << '\n'; }
	
	}

	if (function == 4) {
		ofstream file("C:/Users/sshunin/Desktop/table.csv");
		for (long int i = 2; i < 25; i++) {
			int num = pow(2, i);
			int* array1 = InputArrayAuto(num);

			file << num << "; " << IndexBinarySearch(array1, 0, num, -1) << '\n';
		}

	}

	if (function == 5) { 
		float _iter;
		cout << "Введите размерность массива: "; cin >> _iter;

		vector<int> arr = InputArray(_iter);
		Print(arr);
		cout << "\nПропущенный элемент: " << findMissingItem(arr);

	}

	cout << '\n'; system("pause");
	return main();
}