// main inclusions
#include <iostream>

// headers
#include "ui.h"
#include "functions.h"

using namespace std;

int main() {
	setlocale(LC_ALL, "RU"); system("chcp 1251"); system("cls");
	Interface ui; int function = ui.mainMenuInit(); system("cls");

	string path = "data.txt";
	
	if (function == 1) addWorker(path);
	if (function == 2) dataOutput(path);
	if (function == 3) findRole(path);

	return main();
}
