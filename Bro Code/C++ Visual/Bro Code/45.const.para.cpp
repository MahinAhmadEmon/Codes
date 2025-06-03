#include <iostream>
using namespace std;
void paintInfo(string name, int age);

int main (){

    // const parameter = parameter that is effectively read-only
    //                   code is more secure & conveyes intent
    //                   usefull for references and pointers

    string name = "Mahin";
    int age = 21;

    paintInfo(name, age);

    return 0;

}
void paintInfo(string name, int age){
    name = " ";
    age = 0;
    cout << name << endl;
    cout << age << endl;


}
