// main inclusions
#include <iostream>

// headers
#include "ui.h"
#include "functions.h"

using namespace std;

int main() {
	setlocale(LC_ALL, "RU"); system("chcp 1251"); system("cls");
	Interface ui; int function = ui.mainMenuInit(); system("cls");
	
	switch (function)
	{
	case 2:
		dataOutput("data.txt");
	}

	return main();
}