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

void Worker::setID(string id) { this->id = id; }

void Worker::setRole(string role) { this->role = role; }

void Worker::setHourSalary(int hour_salary) { this->hour_salary = hour_salary; }

void Worker::setHoursAmount(int hours_amount) { this->hours_amount = hours_amount; }

string Worker::getDataline() { return id + '|' + role + '|' + to_string(hours_amount) + '|' + to_string(hour_salary); }

string Worker::getRole() { return role; }