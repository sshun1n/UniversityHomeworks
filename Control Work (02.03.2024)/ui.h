#pragma once

// class header
#include "classes.h"

string Interface::separator(int size) {
	string temp = "";
	for (int i = 0; i < size; i++) temp += "-";

	return temp;
}
void Interface::inputError() {
	system("cls"); cout << "Ошибка! Неправильно выбран пункт меню.\n" << separator(45) << "\n"; system("pause");
}
int Interface::mainMenuInit() {
	int inputFunction;
	cout << "Меню:\n" << separator(50) << "\n[1] Ввод данных сотрудника\n[2] Вывод и изменение структуры данных\n[3] Найти сотрудников по должности\n[4] Вывод и изменение текущего списка должностей\n" << separator(50) << "\nВвод: ";
	cin >> inputFunction;
	if (inputFunction < 1 or inputFunction > 4) { inputError(); return -1; }

	return inputFunction;
}
int Interface::dataReductMenu() {
	int inputFunction;
	cout << "Меню:\n[1] Редактировать базу данных\n[2] Выход\n\nВвод:"; cin >> inputFunction;
	if (inputFunction < 1 or inputFunction > 2) { inputError(); return -1; }
	return inputFunction;
}