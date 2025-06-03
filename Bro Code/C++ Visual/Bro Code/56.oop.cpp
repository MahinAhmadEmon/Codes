#include <iostream>
using namespace std;

class Car{
    public:
        string make;
        string model;
        int year;
        string color;

        void accelarate(){
            cout << "You step on the gas!\n";
        }
        void brake(){
            cout << "You step on the brakes!\n";
        }
};

int main (){
    //object = A collection of attributes and methods
    //         They can have a characteristics and could perform actions
    //         Can be used to mimic real world items (ex. Phone, Book, Dog)
    //         Created from a class which acts as a "blue-print"
    Car car1;
    car1.make = "Ford";
    car1.model = "Mustang";
    car1.year = 2023;
    car1.color = "red";

    cout << car1.make << endl;
    cout << car1.model << endl;
    cout << car1.year << endl;
    cout << car1.color << endl;

    car1.accelarate();
    car1.brake();
    return 0;
}