#include <iostream>
using namespace std;

int main () {

   // && = check if two conditions are true
   // || = check if at least one of the two conditions is true
   // !  = reverse the logical state of its operand

    int temp;
    bool sunny = false;

    cout << "Enter The temperature: ";
    cin >> temp;

    if (temp <= 0 || temp >= 30){
        cout << "The temperature is BAD!\n";
    }
    else {
        cout << "The temperature is GOOD!\n";
    }

    if (!sunny){
        cout << "It is Couldy";
    }
    else{
        cout << "It is Sunny";
    }

return 0;
}