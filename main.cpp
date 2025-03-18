#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

const double MAX_ITER = 1000;
const double EPSILON = 0.045;
const double DELTA = 0.001;
const double PHI = (sqrt(5) - 1) / 2;

double f(double x) {
    return (1 - pow(x, 2)) * (1 - pow(x, 3));
}

double df(double x) {
    return 5 * pow(x, 4) - 3 * pow(x, 2) - 2 * x;
}

double ddf(double x) {
    return 20 * pow(x, 3) - 6 * x - 2;
}


double bitwise_search(double a, double b) {
    double delta = (b - a) / 4.0;
    double x0 = a;
    double x1, f0, f1;
    int iteration = 0;

    f0 = f(x0);

    while (delta > EPSILON) {
        cout << (iteration == 0 ? "" : "\n") << "\t[Движемся вправо]\n";
        while (true) { //Цикл двигается вправо
            x1 = x0 + delta;
            f1 = f(x1);

            iteration++;
            cout << left << "x = " << setw(15) << x1 << "f(x) = " << setw(15) << f1 << " [" << iteration << "]" << endl;

            if (f0 > f1) {
                x0 = x1;
                f0 = f1;
                if (x0 < a) x0 = a;
                else if (x0 >= b) x0 = b;
            } 
            else break;
        }

        delta /= 4.0; //Уменьшение шага
        x0 = x1;
        f0 = f(x0);

        cout << (iteration == 0 ? "" : "\n") << "\t[Движемся влево]\n";

        while (true) //Цикл движется влево
        {
            x1 = x0 - delta;
            f1 = f(x1);

            iteration++;
            cout << left << "x = " << setw(15) << x1 << "f(x) = " << setw(15) << f1 << " [" << iteration << "]" << endl;

            if (f0 > f1) {
                b = x0;
                x0 = x1;
                f0 = f1;
                if (x0 < a) x0 = a;
                else if (x0 > b) x0 = b;
            }
            else break;
        }
    }
    return x0;
}

double dichotomy(double a, double b) {
    double x1, x2;
    int iteration = 0;

    // Цикл продолжается, пока ширина интервала больше заданной точности EPSILON
    while ((b - a) / 2 > EPSILON) {
        iteration++;

        // Находим два средних значения x1 и x2 с учетом EPSILON
        x1 = (b + a - EPSILON) / 2;
        x2 = (b + a + EPSILON) / 2;

        // Вычисляем значения функции в точках x1 и x2
        double f1 = f(x1);
        double f2 = f(x2);

        std::cout << left << "a = " << setw(15) << a << "b = " << setw(15) << b
            << "x1 = " << setw(15) << x1 << "x2 = " << setw(15) << x2 << "f(x1) = "
            << setw(15) << f1 << "f(x2) = " << setw(15) << f2 << " [" << iteration << "]" << std::endl;

        if (f1 <= f2) b = x2; // Если f1 меньше или равно f2, сужаем интервал до [a, x2]
        else a = x1; // Иначе сужаем интервал до [x1, b]
    }
    return (a + b) / 2;
}

double golden_ratio(double a, double b) {
    // Вычисляем две точки x1 и x2, используя коэффициент золотого сечения (PHI)
    double x1 = a + (1 - PHI) * (b - a);
    double x2 = a + PHI * (b - a);

    double f1 = f(x1);
    double f2 = f(x2);

    int iteration = 0;

    // Цикл продолжается, пока ширина интервала больше или равна заданной точности EPSILON
    while ((b - a) >= EPSILON) {
        iteration++;
        cout << left << "a = " << setw(15) << a << "b = " << setw(15) << b << "x1 = " << setw(15)
            << x1 << "x2 = " << setw(15) << x2 << "f(x1) = " << setw(15) << f1 << "f(x2) = "
            << setw(15) << f2 << "[" << iteration << "]" << endl;

        // Сравниваем значения функции в точках x1 и x2
        if (f1 <= f2) {
            // Если f1 меньше или равно f2, сужаем интервал до [a, x2]
            b = x2; // Обновляем правую границу
            x2 = x1; // Перемещаем x2 на x1
            f2 = f1; // Перемещаем f2 на f1
            
            x1 = a + (1 - PHI) * (b - a); // Вычисляем новое значение x1
            f1 = f(x1); // Вычисляем новое значение функции f(x1)
        }
        else {
            // Если f2 меньше f1, сужаем интервал до [x1, b]
            a = x1; // Обновляем левую границу
            x1 = x2; // Перемещаем x1 на x2
            f1 = f2; // Перемещаем f1 на f2

            x2 = a + PHI * (b - a); // Вычисляем новое значение x2
            f2 = f(x2); // Вычисляем новое значение функции f(x2)
        }
    }

    return (a + b) / 2;
}

double middle_point(double a, double b) {
    double ak = a;
    double bk = b;
    double xk;
    int iteration = 0;

    // Цикл продолжается, пока ширина интервала больше половины заданной точности EPSILON
    while ((bk - ak) / 2 > EPSILON) {
        xk = (ak + bk) / 2; // Вычисляем среднюю точку интервала
        double df_xk = df(xk); // Вычисляем производную функции в точке xk
        iteration++;

        cout << left << "a = " << setw(15) << ak << "b = " << setw(15) << bk
            << "x = " << setw(15) << xk << "f(x) = " << setw(15) << f(xk)
            << "f'(x) = " << setw(15) << df(xk) << " [" << iteration << "]" << endl;

        if (abs(df_xk) < EPSILON) break; // Если производная близка к нулю, выходим из цикла

        // Обновляем границы интервала в зависимости от знака производной
        if (df_xk < 0) ak = xk; // Если производная отрицательна, сужаем интервал до [xk, bk]
        else bk = xk; // Если производная положительна, сужаем интервал до [ak, xk]
    }
    return (ak + bk) / 2;
}

double chord_method(double a, double b) {
    double x_tilda;
    int iteration = 0;

    if (df(a) < 0 && df(b) < 0) return b; // Если производные обеих границ отрицательны, возвращаем b
    if (df(a) > 0 && df(b) > 0) return a; // Если производные обеих границ положительны, возвращаем a

    // Цикл продолжается, пока разница между b и a больше заданной точности EPSILON
    while (fabs(b - a) > EPSILON) {
        iteration++;
        if (iteration == MAX_ITER) return x_tilda;

        // Проверка на деление на ноль
        if (fabs(df(a) - df(b)) < 1e-9) {
            cerr << "Ошибка: деление на ноль при вычислении x_tilda" << endl;
            return (a + b) / 2; // Возвращаем среднее значение, если производные равны
        }

        // Вычисляем новую точку по формуле метода хорд
        x_tilda = a - df(a) * (a - b) / (df(a) - df(b));

        cout << left << "a = " << setw(15) << a << "b = " << setw(15) << b
            << "x = " << setw(15) << x_tilda << "f(x1) = " << setw(15)
            << f(x_tilda) << "f'(x2) = " << setw(15) << df(x_tilda)
            << "[" << iteration << "]" << endl;

        if (fabs(df(x_tilda)) <= EPSILON) return x_tilda; // Если производная близка к нулю, возвращаем x_tilda
        if (df(x_tilda) > 0) b = x_tilda; // Если производная положительна, сужаем интервал до [a, x_tilda]
        else a = x_tilda; // Если производная отрицательна, сужаем интервал до [x_tilda, b]
    }
    return (a + b) / 2;
}

double newton_method(double a, double b) {
    double x = (a + b) / 2;
    int iteration = 0;

    // Цикл продолжается, пока абсолютное значение производной больше заданной точности EPSILON
    while (abs(df(x)) > EPSILON) {
        iteration++;
        // Проверка на слишком малое значение второй производной
        if (fabs(ddf(x)) < 1e-9) { cout << "Вторая производная слишком мала для данного метода"; return -1; }
        x = x - (df(x) / ddf(x)); // Обновляем значение x по формуле метода Ньютона
        cout << left << "x = " << setw(15) << x << "f(x) = " << setw(15) << f(x)
            << "f'(x) = " << setw(15) << df(x) << "f''(x) = " << setw(15) << ddf(x)
            << " [" << iteration << "]" << endl;
    }
    return x;
}

int main() {
    setlocale(LC_ALL, "ru");

    double result = -1;
    double a = 0.5;
    double b = 5;
    int choice;

    cout << "Метод дихотомии [1]\nМетод поразрядного поиска [2]\nМетод золотого сечения [3]\n"
        << "Метод средней точки [4]\nМетод хорд [5]\nМетод Ньютона [6]\n\nВвод: ";
    cin >> choice; system("cls");

    if (choice == 1) result = dichotomy(a, b);
    else if (choice == 2) result = bitwise_search(a, b);
    else if (choice == 3) result = golden_ratio(a, b);
    else if (choice == 4) result = middle_point(a, b);
    else if (choice == 5) result = chord_method(a, b);
    else if (choice == 6) result = newton_method(a, b);
    else {
        printf("Ошибка ввода, незвестное значение: %d\n", choice);
        system("pause"); system("cls");
        return main();
    }

    printf("\nМинимум функции находится в точке x = %.4f\n", result);
    printf("Значение функции в этой точке f(x) = %.4f\n", f(result));
    system("pause"); system("cls");

    return main();
}