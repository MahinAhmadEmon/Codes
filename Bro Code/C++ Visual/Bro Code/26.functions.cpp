#include <iostream>
using namespace std;
void happyBirthday(string name, int age){
    cout << "Happy birthday " << name << '\n';
    cout << "Happy birthday " << name << '\n';
    cout << "Happy birthday to dear " << name << '\n';
    cout << "Happy birthday " << name << '\n';
    cout << "You are age " << age << " Years old.\n";
}

int main (){

//function = a block of reusable code

string name = "Mahin";

int age = 21;

happyBirthday(name, age);

return 0;
}