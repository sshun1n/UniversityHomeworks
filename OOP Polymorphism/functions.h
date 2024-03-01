#pragma once
// main includes
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