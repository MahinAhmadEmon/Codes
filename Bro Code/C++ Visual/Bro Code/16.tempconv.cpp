#include <iostream>
using namespace std;

int main(){

    double temp;

    char unit;

    cout << "******** temp convertion ********\n";
    cout << "F = Fahrenheit\n";
    cout << "C = Celsius\n";

    cout << "What unit do like like to convert to: ";
    cin >> unit;

    if(unit == 'F' || unit == 'f'){
        cout << "Enter the temperature in Celsius: ";
        cin >> temp;

        temp = (1.8 * temp) + 32.0;
        cout << "Tempareture is: " << temp << "F\n";
    }
    else if (unit == 'C' || unit == 'c'){
        cout << "Enter the tempareture in Fahrenheit: ";
        cin >> temp;

        temp = (temp - 32) /1.8;
        cout << "The tempareture is: " << temp << "C\n";
    }

    else{
        cout << " Please Enter Only C or F\n";
    }


    cout << "********************************";

    return 0;
}