#pragma once

// main inclusions
#include <vector>
#include <fstream>
#include <sstream>

// headers
#include "ui.h"
#include "classFunctions.h"

using namespace std;

Interface ui;

bool existanceCheck(string path) { ifstream file(path); if (!file) { return false; } file.close(); return true; }

vector<Worker> loadData(string path) {
	vector<Worker> data;
	if (!existanceCheck(path)) ui.fileError();
	else {
		ifstream file(path); string line, id, role; int hours_amount = 0, hour_salary = 0;

		while (getline(file, line)) {
			istringstream iss(line); string temp; int index = 0;

			while (getline(iss, temp, '|')) {
				if (index == 0) id = temp;
				if (index == 1) role = temp;
				if (index == 2) hours_amount = atoi(temp.c_str());
				if (index == 3) hour_salary = atoi(temp.c_str());
				index++;
			}
			data.push_back(Worker(id, role, hour_salary, hours_amount));
		} file.close();
	}

	return data;
}

void addWorker(string path) {
	string id, role; int hours_amount, hour_salary;

	cout << "Имя сотрудника: "; cin.ignore(); getline(cin, id);
	cout << "\nДолжность сотрудника: "; getline(cin, role);
	cout << "\nПочасовая оплата: "; cin >> hour_salary;
	cout << "\nКол-во отработанных часов: "; cin >> hours_amount;

	if (!existanceCheck(path)) { ofstream file(path); file << id << '|' << role << '|' << hours_amount << '|' << hour_salary << '\n'; file.close(); }
	else { ofstream file(path, ios::app); file << id << '|' << role << '|' << hours_amount << '|' << hour_salary << '\n'; file.close(); }

	system("cls"); cout << "Успешно записан сотрудник " << id << "\n\n"; system("pause");
}

void reductMenu(string path, vector<Worker> data) {
	int id;
	cout << "Актуальная структура данных:\n\n " << ui.separator(151) << '\n';
	for (int i = 0; i < data.size(); i++) { cout << "|[" << i + 1 << "]|"; data[i].print(); } cout << " " << ui.separator(151) << "\n\n\n";

	cout << "Введите ID сотрудника на редактирование (0 - выход): "; cin >> id; id--; system("cls");

	if (id != -1) {
		string temp;

		data[id].lineByLinePrint();
		int function = ui.reductMenu();
		system("cls");

		if (function == 1) { cout << "Введите новое ФИО сотрудника: "; cin.ignore(); getline(cin, temp); data[id].setID(temp); }
		if (function == 2) { cout << "Введите новую должность сотрудника: "; cin.ignore(); getline(cin, temp); data[id].setRole(temp); }
		if (function == 3) { cout << "Введите новый оклад сотрудника: "; cin >> temp; data[id].setHourSalary(stoi(temp)); }
		if (function == 4) { cout << "Введите кол-во отработанных сотрудником часов: "; cin >> temp; data[id].setHoursAmount(stoi(temp)); }
		if (function == 5) { data.erase(data.begin() + id); }

		ofstream file(path); for (auto person : data) { file << person.getDataline() << '\n'; } file.close();

	}

}

void dataOutput(string path) {
	vector<Worker> data = loadData(path);

	if (existanceCheck(path)) {
		cout << "Актуальная структура данных:\n\n " << ui.separator(151) << '\n';

		for (int i = 0; i < data.size(); i++) { cout << "|[" << i + 1 << "]|"; data[i].print(); } cout << " " << ui.separator(151) << "\n\n\n";
		int function = ui.dataReductMenu(); system("cls");

		if (function == 1) { reductMenu(path, data); }
	}
}

void findRole(string path) {
	string role; vector<Worker> data = loadData(path); int counter = 1; bool flag = false;
	cout << "Введите должность для поиска: "; cin.ignore(); getline(cin, role); system("cls");
	
	cout << "Сотрудники на должности '" << role << "':\n\n " << ui.separator(151) << '\n';
	for (auto worker : data) { if (worker.getRole() == role) { flag = true; cout << "|[" << counter << "]|"; worker.print(); counter++; } } 
	
	if (flag) { cout << " " << ui.separator(151) << "\n\n\n"; }
	else { system("cls"); cout << "Сотрудники на должности '" << role << "' не найдены.\n\n"; }

	system("pause");
}