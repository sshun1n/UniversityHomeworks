#pragma once
// main inclusions
#include <iomanip>

// class header 
#include "classes.h"

void Worker::print() {

	cout << "| ФИО: " << setw(30) << left << id << "| Должность: " << setw(19) << role << "| Почасовой оклад: " << setw(7) << hour_salary << "| Кол-во отработанных часов: " << setw(5) << hours_amount << "| Выплата: " << setw(8) << hour_salary * hours_amount << "|\n";

}