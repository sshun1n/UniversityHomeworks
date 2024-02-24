#pragma once

// main includes
#include <iostream>
#include <string>
#include <iomanip>

using namespace std;


// [ 1ST ]

class Student {
public:
    // custom constructor
    Student(string firstName, string lastName, string group, double averageMark) : firstName(firstName), lastName(lastName), group(group), averageMark(averageMark) {}

    // methodes
    virtual int getScholarship() const {
        if (averageMark == 5) return 2000;

        return 1900;
    }

private:
    // variables
    string firstName, lastName, group; double averageMark;

};

class Aspirant : public Student {
public:
    // custom constructor
    Aspirant(string firstName, string lastName, string group, string scienceWork, double averageMark) : Student(firstName, lastName, group, averageMark), scienceWork(scienceWork), averageMark(averageMark) {}

    // methodes override
    int getScholarship() const override {
        if (averageMark == 5) return 2500;

        return 2200;
    }

private:
    // child variables
    string scienceWork; double averageMark;

};

void firstInit() {
    const int arraySize = 4;

    Student* students[arraySize];

    students[0] = new Student("����", "���", "��� 23", 5);
    students[1] = new Aspirant("�����", "����", "��� 23", "�������� ��������", 5);
    students[2] = new Student("����", "���", "��� 23", 4);
    students[3] = new Aspirant("���", "�������", "��� 23", "������������� �����", 4);

    for (int i = 0; i < arraySize; i++) cout << "���������: " << students[i]->getScholarship() << '\n'; cout << '\n'; system("pause");

    for (int i = 0; i < arraySize; ++i) delete students[i];
}


// [ 2ND ]

class User {
public:
    // default constructor
    User() : name("None"), age(-1) {}

    // methodes
    void setName(string name) { this->name = name; } void setAge(int age) { this->age = age; }
    string getName() { return name; } int getAge() { return age; }

private:
    // variables
    string name; int age;
};

class Worker : public User {
public:
    // default constructor
    Worker() : User(), salary(-1) {}

    // methodes
    void setSalary(float salary) { this->salary = salary; }
    float getSalary() { return salary; }

private:
    // variables
    float salary;
};

class Driver : public Worker {
public:
    // default constructor
    Driver() : Worker(), drivingExperience(-1), drivingCategory("None") {}

private:
    // variables
    int drivingExperience; string drivingCategory;
};

void secondInit() {

    Worker Ivan; Ivan.setName("����"); Ivan.setAge(25); Ivan.setSalary(1000);
    Worker Vasya; Vasya.setName("����"); Vasya.setAge(26); Vasya.setSalary(2000);

    cout << "������� ��������, �� ������� ���������� '" << Ivan.getName() << "' � '" << Vasya.getName() << "': " << ( Ivan.getSalary() + Vasya.getSalary() ) / 2 << '\n'; system("pause");
}


// [ 3RD ]

class Animal {
public:
    // constructor
    Animal(string name) : name(name) {}

    // methodes
    virtual void makeNoise() const { cout << "���� ���������\n"; } virtual void eat() const { cout << "����� ��� ���� ������\n"; } virtual void getDescription() const { cout << "�������� ���������\n"; }
    void getName() { cout << "��� ���������: " << name << '\n'; }

protected:
    // variables
    string name;
};

class Dog : public Animal {
public:
    // constructor
    Dog(string name) : Animal(name) {}

    // override
    void makeNoise() const override { cout << "(������) ���! ���!\n"; }
    void eat() const override { cout << "������ ����, ��� �������� ��������:\n   + ����, �����\n   + ������� � ����������� ����\n   + ���� �� ����(���, ������, �������, �������)\n   + ����� � ������ ����\n   + ������\n   + ����� �����(����� ���������)\n   + ������� ����(�� ���� 1 - 2 ��� � ������)\n\n"; }
    void getDescription() const override { cout << "�������� ���������:\n   ������ - ��� �������� ��������.\n\n   � ������ ������ ����, ������� ��� ����� ����� ����� ���� ����, � ��� ������ ����,\n   ��� ���, ��� �����, �����, ��� � ���. ��� ����� ����� �������� � ����� ������� ��� ����� �����.\n\n   ��� ����� ����� ������, ������ ���� � �������� �� �����������.\n   ������ ������� ����� ������� �� ���������. ����� ����� ����� ������� � ����.\n   ��� ����� ������ ��������. � ��� ������ �� � ������� ������� ��������.\n\n"; }
};

class Cat : public Animal {
public:
    // constructor
    Cat(string name) : Animal(name) {}

    // override
    void makeNoise() const override { cout << "(�����) ���.\n"; }
    void eat() const override { cout << "������ ����, ��� �������� ��������:\n   + ���� ������, �������, ������� ������� (������, �������, ������� ����)\n   + ��������, ��������, ��������, �����������, ������ �����������(������, ����, ������, ������)\n   + ������������� ��������, ����\n   + ������� ������� ����(���, ������, �������, ������, ������, ��������)\n   + ������������, �������� ����\n   + ������, �����, �����, �����\n\n"; }
    void getDescription() const override { cout << "�������� ���������:\n   �����. ����� - �������� ��������.\n\n   �������� ����� - ���������� ��������, ���������� �������� ����������� � ������������� � �������,\n   ������� ���������� � �������� ������� ������� � ������.\n   ��������� � ��������� ��������, ����������� ����� ������������ ������ ������ �����.\n\n"; }
};

class Veterinar {
public:
    // methodes
    void treatAnimal(Animal* animal) { cout << "[���������]\n"; animal->getName(); animal->getDescription(); animal->eat(); }
};

void thirdInit() {
    const int arraySize = 2;

    Animal* animals[arraySize]; Veterinar vet;

    animals[0] = new Dog("�����"); animals[1] = new Cat("������");

    vet.treatAnimal(animals[0]); vet.treatAnimal(animals[1]);

    for (int i = 0; i < arraySize; ++i) delete animals[i];

    system("pause");
}

// [ 4TH ]

class Shape {
public:
    // constructor
    Shape(string color) : color(color) {}

    // methodes
    virtual void draw() const { cout << "����� ������ (����: " << color << ").\n"; }

private:
    // variables
    string color;
};

class Circle : public Shape {
public:
    // constructor
    Circle(string color, float xCoord, float yCoord) : Shape(color), color(color), xCoord(xCoord), yCoord(yCoord) {}

    // methodes
    void draw() const override { cout << "����� ���� (����: " << color << ", x: " << xCoord << ", y: " << yCoord << ").\n"; }

private:
    // variables
    float xCoord, yCoord; string color;
};

class Rectangle : public Shape {
public:
    // constructor
    Rectangle(string color, float xCoord, float yCoord) : Shape(color), color(color), xCoord(xCoord), yCoord(yCoord) {}

    // methodes
    void draw() const override { cout << "����� ������������� (����: " << color << ", x: " << xCoord << ", y: " << yCoord << ").\n"; }

private:
    // variables
    float xCoord, yCoord; string color;
};

void fourthInit() {
    const int arraySize = 2;

    Shape* shapes[arraySize];

    shapes[0] = new Circle("�������", 5.32, 6.0);
    shapes[1] = new Rectangle("�������", 1.42, 2.88);

    for (int i = 0; i < arraySize; i++) shapes[i]->draw();
    for (int i = 0; i < arraySize; i++) delete shapes[i];

    system("pause");
}

// [ 5TH ]

class Product {
public:
    // counstructor
    Product(string name, float price, float rating) : name(name), price(price), rating(rating) {}

    // methodes
    string getName() { return name; } float getPrice() { return price; } float getRating() { return rating; }

private:
    // variables
    string name; float price, rating;
};

class Category {
public:
    // constructor
    Category(string categoryName, Product* productsList) : categoryName(categoryName), productsList(productsList) {}

    // methodes
    void printProducts(int iter) { cout << categoryName << ":\n"; for (int i = 0; i < iter; i++) { cout << "   " << left << setw(22) << productsList[i].getName() << setw(10) << productsList[i].getPrice() << setw(10) << productsList[i].getRating() << '\n'; } }

private:
    // variables
    string categoryName; Product* productsList;
};

class Basket {
public:
    // constructor
    Basket(Product* purchasedProducts) : purchasedProducts(purchasedProducts) {}

    // methodes
    string getName(int num) { return purchasedProducts[num].getName(); }

private:
    // variables
    Product* purchasedProducts;
};

class _User {
public:
    // constructor
    _User(string login, string password, Basket* basket) : login(login), password(password), basket(basket) {}

    // methodes
    void printPurchasedProducts(int iter) { cout << "����������: " << login << "\n������ �������:\n"; for (int i = 0; i < iter; i++) { cout << "   [" << i + 1 << "] " << basket->getName(i) << '\n'; } }

private:
    // variables
    string login, password; Basket* basket;
};

void fifthInit() {
    int categoriesSize[3] = { 4, 5, 3 }; int basketsSize[3] = { 3, 2, 4 }; int function;

    Product milky[4] = {
        Product("������ 3,2%", 112.99, 4.2),
        Product("������ ��������", 143, 3.7),
        Product("������ ��������", 93.99, 4.9),
        Product("�������", 89.75, 2.9)
    };
    Product meaty[5] = {
        Product("������� ����������", 234.99, 4.3),
        Product("��������� ��������", 162.50, 4.1),\
        Product("������ �������", 177.20, 4.6),
        Product("�������", 210.3, 4.17),
        Product("�������", 152.52, 5.0)
    };
    Product bread[3] = {
        Product("���� �����", 34.23, 4.8),
        Product("���� ������", 32.99, 3.2),
        Product("����� �����������", 82.99, 4.6)
    };

    Category* categories[3] = {
        new Category("�������� ���������", milky),
        new Category("������ �����", meaty),
        new Category("������� �����", bread)
    };
    
    Product items1[3] = { milky[2], meaty[1], bread[0] };
    Product items2[2] = { milky[1], bread[2] };
    Product items3[4] = { bread[1], milky[0], meaty[4], meaty[0] };

    Basket* baskets[3] = {
        new Basket(items1),
        new Basket(items2),
        new Basket(items3)
    };

    _User* users[3] = {
        new _User("vanya2003", "vanyanevanya", baskets[0]),
        new _User("sshunin", "12314543", baskets[1]),
        new _User("egor", "neEgor", baskets[2])
    };

    cout << "[1] ������� ���������\n[2] ������� �����������\n\n����: "; cin >> function;

    
    if (function == 1) { system("cls"); for (int i = 0; i < 3; i++) { categories[i]->printProducts(categoriesSize[i]); cout << '\n'; } }

    else if (function == 2) { system("cls"); for (int i = 0; i < 3; i++) { users[i]->printPurchasedProducts(basketsSize[i]); cout << '\n'; } }

    else cout << "������ �����";

    system("pause");
}