// main includes
#include <iostream>
#include <string>

// headers
#include "functions.h"

using namespace std;



int main() {
    setlocale(LC_ALL, "RU"); system("chcp 1251"); system("cls");
	int inputFunction;

	cout << "[1] Student, Aspirant\n[2] User, Worker, Driver\n[3] Animal\n[4] Фигуры\n[5] Интернет магазин\n\nВвод: "; cin >> inputFunction;

	switch (inputFunction) {
	case 1:
		system("cls"); firstInit(); main();

	case 2:
		system("cls"); secondInit(); main();

	case 3:
		system("cls"); thirdInit(); main();

	case 4:
		system("cls"); fourthInit(); main();

	case 5:
		system("cls"); fifthInit(); main();

	default:
		cout << "Ошибка ввода! Повторите попытку.\n"; system("pause"); main();
	}

    return 0;
}
