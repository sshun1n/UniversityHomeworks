// main inclusions
#include <iostream>
#include <vector>

// headers
#include "functions.h"

using namespace std;

int main() {
	setlocale(LC_ALL, "RU"); system("chcp 1251"); system("cls");
	int inputFunction;

	cout << "Номер задания: "; cin >> inputFunction; system("cls");

	if (inputFunction == 1) {
		Rational a(1, 2), b(5, 4), temp = a + b;
		cout << "Сумма: "; temp.print(); temp = a * b;
		cout << "\nПроизведение: "; temp.print();
	}
	if (inputFunction == 2) {
		Vector a(2, 5), b(3, 7);
		cout << a * b;
	}
	if (inputFunction == 3) {
		MaxMethods null;
		cout << null.Max(1, 2) << '\n' << null.Max(1, 2, 3) << '\n' << null.Max(1, 2, 3, 4);
	}
	if (inputFunction == 4) {
		vector<int> a = { 1, 2, 3, 4, 5, 6, 7, 8 }; vector<float> b = { 1.2, 2.3, 3.4, 4.5, 5.6, 6.7, 7.8, 8.9 };
		AverageMethods method;

		cout << method.Average(a) << '\n' << method.Average(b);
	}
	if (inputFunction == 5) {
		Circle a; Circle b(10); Circle c(2, 5); Circle(2, 5, 10);
	}
	if (inputFunction == 6) { 
		cout << "Было реализованно ранее."; 
	}
	if (inputFunction == 7) {
		Car car; Bicycle bicycle;
		cout << "Скорость автомобиля:\n";
		for (int i = 0; i < 10; i++) {
			cout << car.getSpeed(); 
			if (i != 9) cout << ", ";
			car.SpeedUp();
		}
		cout << "\nСкорость велосипеда:\n";
		for (int i = 0; i < 10; i++) {
			cout << bicycle.getSpeed(); 
			if (i != 9) cout << ", ";
			bicycle.SpeedUp();
		}
	}
	if (inputFunction == 8) {
		_Circle circle(5); Rectangle rectangle(5, 10); Triangle triangle(5, 6);

		cout << "Площадь круга равна: " << circle.CalculationArea();
		cout << "\nПлощадь прямоугольника равна: " << rectangle.CalculationArea();
		cout << "\nПлощадь треугольника равна: " << triangle.CalculationArea();
	}
	if (inputFunction == 9) {
		Manager manager; Programmer programmer;

		cout << "Зарплата менеджера: " << manager.CalculateSalary() << "\nЗарплата программиста: " << programmer.CalculateSalary();
	}
	if (inputFunction == 10) {
		Football footbal; Basketball basketball; Rugby rugby;
		footbal.play(); basketball.play(); rugby.play();
	}
	if (inputFunction == 11) {
		Circle1 circle(5); Rectangle1 rectangle(5, 10); Triangle1 triangle(5, 6);

		cout << "Площадь круга равна: " << circle.getArea() << " Периметр: " << circle.getPerimeter();
		cout << "\nПлощадь прямоугольника равна: " << rectangle.getArea() << " Периметр: " << rectangle.getPerimeter();
		cout << "\nПлощадь треугольника равна: " << triangle.getArea() << " Периметр: " << triangle.getPerimeter();
	}
	if (inputFunction == 12) {
		cout << "Было реализованно ранее.";
	}
	if (inputFunction == 13) {
		cout << "Было реализованно ранее.";
	}
	if (inputFunction == 14) {
		SavingsAccount savings; CheckingAccount checking;
		savings.deposit(10000); checking.deposit(10000);
		savings.withdraw(5000); checking.withdraw(7000);
		savings.withdraw(6000);
	}
	if (inputFunction == 15) {
		_Car car; _Motorcycle bike;

		car.startEngine(); bike.startEngine(); car.stopEngine(); bike.stopEngine();
	}
	if (inputFunction == 16) {
		cout << "Было реализованно ранее.";
	}

	cout << '\n'; system("pause"); main();

	return 0;
}
