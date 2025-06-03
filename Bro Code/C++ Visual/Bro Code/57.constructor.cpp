#include <iostream>
using namespace std;

class Car{
    public:
        string make;
        string model;
        int year;
        string color;

    Car (string x, string  y, int i, string z){
        make = x;
        model = y;
        year = i;
        color = z;
    }
};

int main (){

    Car car1("Ford", "Mustang" , 2023, "Red");
        cout << car1.make << endl;
        cout << car1.model << endl;
        cout << car1.year << endl;
        cout << car1.color << endl;

    return 0;
}
