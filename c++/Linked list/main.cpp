#include "LinkedList.h"
#include "Solution.h"

using namespace std;

int main() {
	setlocale(LC_ALL, "RU"); system("chcp 1251"); system("cls");
	List list;
	int func, size;

	cout << "[1] Заполнить список рандомно\n[2] Заполнить список с клавиатуры\n\nВвод: "; cin >> func; system("cls");
	cout << "Введите количество элементов: "; cin >> size; system("cls");
	
	if (func == 1) { vector<int> array = randArray(size); list = fromArrToList(array); }
	if (func == 2) { list = InputList(size); }

	MainMenu(list);

	return 0;
}