#include <iostream>
using namespace std;
int main () {
    string name;
    cout << "Enter your name: ";
    getline(cin, name);

    name.erase(0, 3);
    cout << name;

    return 0;
}