#pragma once
// main inclusions
#include <iomanip>

// class header 
#include "classes.h"

void Worker::print() {
	cout << " ФИО: " << setw(30) << left << id << "| Должность: " << setw(19) << role << "| Почасовой оклад: " << setw(7) << hour_salary << "| Кол-во отработанных часов: " << setw(5) << hours_amount << "| Выплата: " << setw(8) << hour_salary * hours_amount << "|\n";
}

void Worker::lineByLinePrint() {
	cout << "ФИО: " << id << "\nДолжность: " << role << "\nПочасовой оклад: " << hour_salary << "\nКол-во отработанных часов: " << hours_amount << "\n\n";
}
string Worker::getDataline() { return id + '|' + role + '|' + to_string(hours_amount) + '|' + to_string(hour_salary); }

bool Worker::compareRole(string role) { return this->role == role; }

void Worker::update(string flag, string temp) { if (flag == "ID") this->id = temp; if (flag == "ROLE") this->role = temp; }

void Worker::update(string flag, int temp) { if (flag == "HS") this->hour_salary = temp; if (flag == "HA") this->hours_amount = temp; }