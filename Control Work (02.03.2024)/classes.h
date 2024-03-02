#pragma once

// main inclusions
#include <iostream>
#include <string>

using namespace std;

class Employee {
public:
	// constructor
	Employee() : id("None"), hours_amount(-1), hour_salary(-1) {}
	Employee(string id, int hour_salary, int hours_amount) : id(id), hours_amount(hours_amount), hour_salary(hour_salary) {}

protected:
	string id;
	int hours_amount, hour_salary;
};
class Worker : public Employee {
public:
	// constructor
	Worker(string id, string role, int hour_salary, int hours_amount) : Employee(id, hour_salary, hours_amount), role(role) {}

	// methods
	void print();
	void lineByLinePrint();
	void setID(string id); void setRole(string role); void setHourSalary(int hour_salary); void setHoursAmount(int hours_amount);
	string getRole();
	string getDataline();

private:
	string role;
};

class Interface {
public:
	// methods
	int mainMenuInit();
	string separator(int size);
	void inputError();
	int dataReductMenu();
	void fileError();
	int reductMenu();
};