#include <iostream>
using namespace std;

int main (){
    //pointers = variable that stores  amemory address od another variable
    //           sometime it's easier to work with an address

    // & address-of operator
    // * dereference operator

    string name = "Mahin";
    int age = 21;
    string *pName = &name;
    int *pAge = &age;
    string freePizzas[5] = {"Pizza 1", "Pizza 2", "Pizza 3", "Pizza 4", "Pizza 5",};
    string *pFreePizzas = freePizzas;

    cout << *pName << endl;
    cout << *pAge << endl;
    for (int i = 0; i < 5; i++){
            cout << *(pFreePizzas + i) << endl;
    }

    return 0;
}