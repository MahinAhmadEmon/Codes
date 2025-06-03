#include <iostream>
using namespace std;

enum Day {Sunday = 0, Monday = 1, Tuseday = 2, Wednesday = 3, 
            Thursday = 4, Friday = 5 , Saturday = 6};

int main (){

    Day today = Friday;

    switch(today){
        case Sunday : cout << "It is Sunday!\n";
                        break;
        case Monday : cout << "It is Monday!\n";
                        break;
        case Tuseday : cout << "It is Tuseday!\n";
                        break;
        case Wednesday : cout << "It is Wednesday!\n";
                        break;
        case Thursday : cout << "It is Thusrday!\n";
                        break;
        case Friday : cout << "It is Friday!\n";
                        break;
        case Saturday : cout << "It is Saturday!\n";
                        break;
    }

    return 0;
}