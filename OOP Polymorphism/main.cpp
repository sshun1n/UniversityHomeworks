// main includes
#include <iostream>
#include <vector>

// headers
#include "functions.h"

using namespace std;

int main() {
	setlocale(LC_ALL, "RU"); system("chcp 1251"); system("cls");
	int inputFunction;

	cout << "Номер задания: "; cin >> inputFunction; system("cls");

	if (inputFunction == 1) {
		Rational a(1, 2), b(5, 4), temp = a + b;
		cout << "Сумма: "; temp.print(); temp = a * b;
		cout << "\nПроизведение: "; temp.print();
	}
	if (inputFunction == 2) {
		Vector a(2, 5), b(3, 7);
		cout << a * b;
	}
	if (inputFunction == 3) {
		MaxMethods null;
		cout << null.Max(1, 2) << '\n' << null.Max(1, 2, 3) << '\n' << null.Max(1, 2, 3, 4);
	}
	if (inputFunction == 4) {
		vector<int> a = { 1, 2, 3, 4, 5, 6, 7, 8 }; vector<float> b = { 1.2, 2.3, 3.4, 4.5, 5.6, 6.7, 7.8, 8.9 };
		AverageMethods method;

		cout << method.Average(a) << '\n' << method.Average(b);
	}

	return 0;
}