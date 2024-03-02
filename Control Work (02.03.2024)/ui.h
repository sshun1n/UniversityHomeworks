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
	cout << "Меню:\n" << separator(50) << "\n[1] Ввод данных сотрудника\n[2] Вывод и изменение структуры данных\n[3] Найти сотрудников по должности\n" << separator(50) << "\nВвод: ";
	cin >> inputFunction;
	if (inputFunction < 1 or inputFunction > 3) { inputError(); return -1; }

	return inputFunction;
}

int Interface::dataReductMenu() {
	int inputFunction;
	cout << "\n[1] Редактировать базу данных\n[2] Выход\n\nВвод: "; cin >> inputFunction;
	if (inputFunction < 1 or inputFunction > 2) { inputError(); return -1; }
	return inputFunction;
}

void Interface::fileError() { 
	system("cls"); cout << "Ошибка! Файл поврежден или не существует!\n"; system("pause");
}

int Interface::reductMenu() {
	int inputFunction;
	cout << "[1] Изменить ФИО сотрудника\n[2] Изменить должность\n[3] Изменить почасовой оклад\n[4] Изменить кол-во часов\n[5] Удалить данные сотрудника\n\nВвод: "; cin >> inputFunction;
	if (inputFunction < 1 or inputFunction > 5) { inputError(); return -1; }

	return inputFunction;
}