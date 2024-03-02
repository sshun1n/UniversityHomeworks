#pragma once
// main inclusions
#include <iostream>
#include <vector>
#include <string>

using namespace std;

// [ 1ST ]
class Rational {
public:
	// construtor
	Rational(float num, float denum) : num(num), denum(denum) {}
	
	// operators
	Rational operator +(Rational fr) { Rational temp((this->num * fr.denum + fr.num * this->denum), (this->denum * fr.denum));  return temp; }
	Rational operator *(Rational fr) { Rational temp((this->num * fr.num), (this->denum * fr.denum)); return temp; }

	void print() { cout << num << "/" << denum; }
private:
	// variables
	float num, denum;

};

// [ 2ND ]
class Vector {
public:
	// constructor
	Vector(int xCoord, int yCoord) : xCoord(xCoord), yCoord(yCoord) {}

	// operators
	int operator *(Vector v) { return this->xCoord * v.xCoord + this->yCoord * v.yCoord; }

private:
	// variables
	int xCoord, yCoord;
};

// [ 3RD ]
class MaxMethods {
public:
	int Max(int a, int b) { return max(a, b); }
	int Max(int a, int b, int c) { return max(a, max(b, c)); }
	int Max(int a, int b, int c, int d) { return max(a, max(b, max(c, d))); }
};

// [ 4TH ]
class AverageMethods {
public:
	int Average(vector<int> p) { int sum = 0; for (auto num : p) { sum += num; } return sum / p.size(); }
	float Average(vector<float> p) { float sum = 0; for (auto num : p) { sum += num; } return sum / p.size(); }
};

// [ 5TH ]
class Circle {
public:
	// default
	Circle() : xCenter(0), yCenter(0), radius(0) { cout << "Конструктор без параметров\n"; }

	// customs
	Circle(float radius) : xCenter(0), yCenter(0), radius(radius) { cout << "Конструктор с 1 параметром\n"; }
	Circle(float xCenter, float yCenter) : xCenter(xCenter), yCenter(yCenter), radius(0) { cout << "Конструктор с 2 параметрами\n"; }
	Circle(float xCenter, float yCenter, float radius) : xCenter(xCenter), yCenter(yCenter), radius(radius){ cout << "Конструктор с 3 параметрами\n"; }

private:
	// variables
	float xCenter, yCenter, radius;
};

// [ 7TH ]
class Vehicle {
public:
	// constructor
	Vehicle() : speed(0) {}

	// virtual method
	virtual void SpeedUp() {}
	float getSpeed() { return speed; }

protected:
	// variables
	float speed;
};
class Car : public Vehicle {
public:
	// constructor
	Car() : Vehicle() {}

	// overrride
	void SpeedUp() override { speed += 10; }
};
class Bicycle : public Vehicle {
public:
	// constructor
	Bicycle() : Vehicle() {}

	// overrride
	void SpeedUp() override { speed += 3; }
};

// [ 8TH ]
class Shape {
public:
	// constructor
	Shape() : a(0), b(0) {}
	Shape(float a) : a(a), b(0) {}
	Shape(float a, float b) : a(a), b(b) {}

	virtual float CalculationArea() { return 0; }

protected:
	// variables
	float a, b;
};
class _Circle : public Shape {
public:
	// constructor
	_Circle(float radius) : Shape(radius) {}

	float CalculationArea() override { return 3.14 * pow(a, 2); }

};
class Rectangle : public Shape {
public:
	// constructor
	Rectangle(float a, float b) : Shape(a, b) {}

	float CalculationArea() override { return a * b; }

};
class Triangle : public Shape {
public:
	// constructor
	Triangle(float a, float h) : Shape(a, h) {}

	float CalculationArea() override { return 0.5 * a * b; }

};

// [ 9TH ]
class Employee {
protected:
	// virtual method
	virtual float CalculateSalary() { return 0; }
};
class Manager : protected Employee {
public:
	float CalculateSalary() override { return 27500; }
};
class Programmer : protected Employee {
public:
	float CalculateSalary() override { return 45270; }
};

// [ 10TH ]
class Sports {
protected:
	virtual void play() const {}
};
class Football : protected Sports {
public:
	void play() const override { cout << "Играем в футбол.\n"; }
};
class Basketball : protected Sports {
public:
	void play() const override { cout << "Играем в баскетбол.\n"; }
};
class Rugby : protected Sports {
public:
	void play() const override { cout << "Играем в регби.\n"; }
};

// [ 11TH ]
class Shape1 {
public:
	// constructor
	Shape1() : a(0), b(0) {}
	Shape1(float a) : a(a), b(0) {}
	Shape1(float a, float b) : a(a), b(b) {}

	virtual float getArea() { return 0; }
	virtual float getPerimeter() { return 0; }

protected:
	// variables
	float a, b;
};
class Circle1 : public Shape1 {
public:
	// constructor
	Circle1(float radius) : Shape1(radius) {}

	float getArea() override { return 3.14 * pow(a, 2); }
	float getPerimeter() override { return 2 * 3.14 * a; }

};
class Rectangle1 : public Shape1 {
public:
	// constructor
	Rectangle1(float a, float b) : Shape1(a, b) {}

	float getArea() override { return a * b; }
	float getPerimeter() override { return (a + b) / 2; }

};
class Triangle1 : public Shape1 {
public:
	// constructor
	Triangle1(float a, float h) : Shape1(a, h) {}

	float getArea() override { return 0.5 * a * b; }
	float getPerimeter() override { return (2 * getArea()) / a; }

};

// [ 14TH ]
class BankAccount {
public:
	// constructor
	BankAccount() : moneyAmount(0) {}

	// methodes
	void deposit(float moneyAmount) { this->moneyAmount += moneyAmount; }
	virtual void withdraw(float moneyAmount) {}

protected:
	// variables
	float moneyAmount;
};
class SavingsAccount : public BankAccount {
public:
	void withdraw(float moneyAmount) override {
		if (moneyAmount > this->moneyAmount) cout << "[Копилка] Ошибка! Средств недостаточно.\n";
		else { cout << "[Копилка] Коммиссия на снятие - 5%.\nЗапрос: " << moneyAmount << ". Выдано: " << moneyAmount * 0.95 << "."; this->moneyAmount -= moneyAmount; cout << " Остаток: " << this->moneyAmount << ".\n\n"; }
	}
};
class CheckingAccount : public BankAccount {
public:
	void withdraw(float moneyAmount) override {
		if (moneyAmount > this->moneyAmount) cout << "[Расчётный счёт] Ошибка! Средств недостаточно.\n";
		else { cout << "[Расчётный счёт] Коммиссия на снятие - 3%.\nЗапрос: " << moneyAmount << ". Выдано: " << moneyAmount * 0.97 << "."; this->moneyAmount -= moneyAmount; cout << " Остаток: " << this->moneyAmount << ".\n\n"; }
	}
};

// [ 15TH ]
class _Vehicle {
protected:
	// virtual methods
	virtual void startEngine() const {}
	virtual void stopEngine() const {}
};
class _Car : protected _Vehicle {
public:
	// override
	void startEngine() const override { cout << "[Автомобиль] Двигатель запущен.\n"; }
	void stopEngine() const override { cout << "[Автомобиль] Двигатель заглушен.\n"; }
};
class _Motorcycle : protected _Vehicle {
public:
	// override
	void startEngine() const override { cout << "[Мотоцикл] Двигатель запущен.\n"; }
	void stopEngine() const override { cout << "[Мотоцикл] Двигатель заглушен.\n"; }
};
