#pragma once

// main inclusions
#include <vector>
#include <fstream>
#include <sstream>

// headers
#include "ui.h"
#include "classFunctions.h"

using namespace std;

vector<Worker> loadData(string path) {
	ifstream file(path); string line, id, role; int hours_amount = 0, hour_salary = 0;
	vector<Worker> data;

	while (getline(file, line)) {
		istringstream iss(line); string temp; int index = 0;

		while (getline(iss, temp, '|')) {
			if (index == 0) id = temp;
			if (index == 1) role = temp;
			if (index == 2) hour_salary = atoi(temp.c_str());
			if (index == 3) hours_amount = atoi(temp.c_str());
			index++;
		}
		data.push_back(Worker(id, role, hour_salary, hours_amount));
	}
	return data;
}

void dataOutput(string path) {
	vector<Worker> data = loadData(path); Interface ui;
	cout << "Актуальная структура данных:\n " << ui.separator(147) << '\n';

	for (int i = 0; i < data.size(); i++) data[i].print(); cout << " " << ui.separator(147) << "\n\n\n";
	int function = ui.dataReductMenu();
}