#include <iostream>
using namespace std;

struct Car{
    string model;
    int year;
    string color;

};
void printCar(Car &car);
void paintCar(Car &car, string color);
int main (){

    Car car1;
    Car car2;

    car1.model = "Mustang";
    car1.year = 2023;
    car1.color = "Red";

    car2.model = "Corvette";
    car2.year = 2024;
    car2.color = "Blue";


    paintCar(car1, "silver");
    paintCar(car2, "gold");

    printCar(car1);
    printCar(car2);

    return 0;
}
void printCar(Car &car){
    cout << &car << '\n';
    cout << car.model << '\n';
    cout << car.year << '\n';
    cout << car.color << '\n';
}

void paintCar(Car &car, string color){
    car.color = color;

}