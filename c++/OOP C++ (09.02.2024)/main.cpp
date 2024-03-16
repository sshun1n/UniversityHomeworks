#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

// Задание №1
class Pet {
private:
	// Переменные класса
	string name, animal_type;
	int age;
public:
	// Коструктор по умолчанию
	Pet() {
		name = "Не задано"; animal_type = "Не задано"; age = -1;
	}

	// Конструктор
	Pet(string name, string animal_type, int age) {
		this->name = name;
		this->animal_type = animal_type;
		this->age = age;
	}

	// Методы класса
	void set_name(string name) { this->name = name; } void set_animal_type(string animal_type) { this->animal_type = animal_type; } void set_age(int age) { this->age = age; }
	void get_name() { cout << name << endl; } void get_animal_type() { cout << animal_type << endl; } void get_age() { cout << age << endl; }
	void print_all() { cout << name << '\n' << animal_type << '\n' << age << '\n'; }
	
};


// Задание №2
class Car {
private:
	// Переменные класса
	string manufacturer; int year_model, speed;

public:
	// Конструктор по умолчанию
	Car() {
		manufacturer = "Не задано"; year_model = -1; speed = 0;
	}

	// Коструктор
	Car(string manufacturer, int year_model) {
		this->manufacturer = manufacturer;
		this->year_model = year_model;
		speed = 0;
	}

	// Методы класса
	void accelerating() { speed += 5; } void breaking() { speed -= 5; } void get_speed() { cout << "Текущая скорость: " << speed << '\n'; }
};


// Задание №3
class Information {
private:
	// Переменные класса
	string name, address, phone_num;
	int age;

public:
	// Коструктор класса
	Information(string name, string address, string phone_num, int age) {

		this->name = name;
		this->address = address;
		this->phone_num = phone_num;
		this->age = age;

	}

	// Методы класса
	void set_name(string name) { this->name = name; } void set_address(string address) { this->address = address; } void set_phone_num(string phone_num) { this->phone_num = phone_num; } void set_age(int age) { this->age = age; }
	void get_info(string type) {
		
		if (type == "name") cout << "[ NAME ] -> " << name << '\n';
		if (type == "address") cout << "[ ADDRESS ] -> " << address << '\n';
		if (type == "phone_num") cout << "[ PHONE NUMBER ] -> " << phone_num << '\n';
		if (type == "age") cout << "[ AGE ] -> " << age << '\n';

	} void get_info() { cout << setw(35) << left << name << setw(25) << address << setw(15) << phone_num << setw(5) << age << '\n'; }

};


// Задание №4
class Employee {
private:
	// Переменные класса
	string FIO, department, position;
	int id;
public:
	// Конструктор класса
	Employee(string FIO, string department, string position, int id) {

		this->FIO = FIO;
		this->department = department;
		this->position = position;
		this->id = id;

	}

	// Методы класса
	void get_info() { cout << setw(20) << left << FIO << setw(10) << id << setw(15) << department << setw(10) << position << '\n'; }

};


// Задание №5
class Retailitem {
private:
	// Метод подсчёта елементов класса
	size_t& Count() {
		static size_t counter = 0; return counter;
	}

	// Переменные класса
	string description;
	int amount; float price;

public:
	// Стандартный коструктор
	Retailitem() { ++Count(); }
	
	// Деконструктор
	~Retailitem() { --Count(); }
	
	// Методы класса
	void set_description(string description) { this->description = description; } void set_amount(int amount) { this->amount = amount; } void set_price(float price) { this->price = price; }
	void get_item() { cout << setw(7) << left << "Товар №" << setw(5) << Count() << setw(10) << description << setw(5) << amount << setw(7) << price << '\n'; }

};


// Задание №6
class Phone {
private:
	// Переменные класса
	string model, number; float weight;

public:
	// Конструктор с 3-мя параметрами
	Phone(string number, string model, float weight) {

		this->number = number;
		this->model = model;
		this->weight = weight;

	}

	// Конструктор с 2-мя параметрами
	Phone(string number, string model) {

		this->number = number;
		this->model = model;
		this->weight = 0;

	}

	// Конструктор без параметров
	Phone() {

		cout << "Телефон включён.\n";

	}

	// Методы класса
	void receiveCall(string name) { cout << "Звонит " << name << ".\n"; }
	string get_number() { return number; }
};


// Задание №7
class Book {
private:
	// Переменные класса
	string author, name, date_of_writing;
	bool status;

public:
	// Конструктор
	Book(string author, string name, string date_of_writing) {

		this->author = author;
		this->date_of_writing = date_of_writing;
		this->name = name;
		status = true;

	}

	// Методы класса
	string get_author() { return author; } string get_name() { return name; } string get_date() { return date_of_writing; }
	void set_status(bool status) { this->status = status; } bool get_status() { return status; }

};

class Reader {
private:
	// Переменные класса
	string id, reader_id, faculty, phone_number, birthday;
	string taken_book_name, taken_book_author, taken_book_date;
	bool taken_book_status;

public:
	// Конструктор по умолчанию
	Reader() {

		id = "None"; reader_id = "-1"; faculty = "None"; phone_number = "-1"; birthday = "00.00.00";

	}

	// Конструктор
	Reader(string id, string reader_id, string faculty, string phone_number, string birthday) {

		this->id = id;
		this->reader_id = reader_id;
		this->faculty = faculty;
		this->phone_number = phone_number;
		this->birthday = birthday;

		cout << "[LOG] Добавлен читатель " << id << '\n';

	}

	// Деконструктор
	~Reader() {
		cout << "[LOG] Читатель " << id << " удален.\n";
	}

	// Методы класса
	void takeBook(Book& book) { 

		taken_book_status = book.get_status();
		taken_book_name = book.get_name();
		taken_book_date = book.get_date();
		taken_book_author = book.get_author();

		if (taken_book_status) {

			book.set_status(false);
			cout << "Книга '" << taken_book_name << "' (" << taken_book_author << ", " << taken_book_date << ") была взята читателем " << id << " (" << reader_id << ", " << faculty << ", " << phone_number << ", " << birthday << ").\n";

		}
		
		else {
			cout << "Книга '" << taken_book_name << "' не может быть взята.\n";
		}

	}
	void returnBook(Book& book) { 

		book.set_status(true);
		cout << "Книга '" << taken_book_name << "' возвращена.\n";

	}

	void set_id(string id) { this->id = id; } void set_reader_id(string reader_id) { this->reader_id = reader_id; } void set_faculty(string faculty) { this->faculty = faculty; }
	void set_phone_number(string phone_number) { this->phone_number = phone_number; } void set_bithday(string birthday) { this->birthday = birthday; }
	void get_info() { cout << setw(20) << left << id << setw(10) << reader_id << setw(35) << faculty << setw(18) << phone_number << setw(8) << birthday << '\n'; }

};

int main() {
	setlocale(LC_ALL, "RU"); system("chcp 1251"); system("cls"); cout << "Номер задания: "; int _function; cin >> _function; system("cls");

	if (_function == 1) {
		Pet garry; garry.print_all();
		cout << '\n';
		Pet sharik("Шарик", "Пёс", 3); sharik.print_all();
	}
	if (_function == 2) {
		Car volvo("Volvo", 2018);

		for (int i = 0; i < 10; i++) {
			volvo.accelerating(); volvo.get_speed();
		}

		for (int i = 0; i < 10; i++) {
			volvo.breaking(); volvo.get_speed();
		}

	}
	if (_function == 3) {
		
		Information itsme("Шунин Степан Алексеевич", "Заречный б-р, 5", "83291321393", 18);
		Information someone("Омаров Порфирий Константинович", "Филевский б-р, 12", "89723219932", 34);
		Information anotherone("Афанасьев Давид Анатольевич", "Кузьмы Минина, 27", "89077164777", 29);

		itsme.get_info("name");
		someone.get_info("address");
		anotherone.get_info("phone_num");

		itsme.get_info(); someone.get_info(); anotherone.get_info();

	}
	if (_function == 4) {

		Employee jack("Джек Джиллехолл", "Актёры", "Главный герой", 421);
		Employee guy("Гай Ричи", "Организация", "Режисер", 1);
		Employee tom("Том Хенкс", "Актёры", "Второстепенный герой", 321);

		jack.get_info(); guy.get_info(); tom.get_info();

	}
	if (_function == 5) {

		Retailitem item; item.set_description("Пылесос"); item.set_amount(12); item.set_price(23.99);
		item.get_item();

		Retailitem jeans; jeans.set_description("Джинсы"); jeans.set_amount(3); jeans.set_price(12.45);
		jeans.get_item(); 

		Retailitem shirt; shirt.set_description("Рубашка"); shirt.set_amount(28); shirt.set_price(9.99);
		shirt.get_item();

	}
	if (_function == 6) {

		Phone galaxy("89500263345", "Galaxy Fold 2", 122.3); galaxy.receiveCall("Влад"); cout << "Номер: " << galaxy.get_number() << '\n';

	}
	if (_function == 7) {

		/*Book pushkin("А.С. Пушкин", "Арбуз 2077", "23.09.1723");
		Reader volodya("Вова", "213002", "Педагогический факультет", "89329042432", "27.12.2000");
		volodya.takeBook(pushkin);
		volodya.takeBook(pushkin); 
		volodya.returnBook(pushkin);*/

		int iterations; cout << "Введите колличество эллементов массива: "; cin >> iterations; system("cls");

		Book green_mile("Стивен Кинг", "Зеленая миля", "01.01.2014");
		Reader* array = new Reader[iterations];

		for (int i = 0; i < iterations; i++) {
			system("cls");

			string id, reader_id, faculty, phone_number, birthday;

			cout << "Введите ФИО: "; cin.ignore(); getline(cin, id); array[i].set_id(id);
			cout << "\nВведите идентификатор читателя: "; cin >> reader_id; array[i].set_reader_id(reader_id);
			cout << "\nВведите факультет: "; cin.ignore(); getline(cin, faculty); array[i].set_faculty(faculty);
			cout << "\nВведите номер телефона: "; cin >> phone_number; array[i].set_phone_number(phone_number);
			cout << "\nВведите дату рождения: "; cin >> birthday; array[i].set_bithday(birthday);
			
			system("cls"); cout << "Добавлен читатель:\n"; array[i].get_info(); system("pause");

		}
		system("cls");

		array[0].takeBook(green_mile);

	}

	cout << "\n-------------------------------------------------\n"; system("pause"); main();
	return 0;
}
