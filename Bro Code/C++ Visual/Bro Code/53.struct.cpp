#include <iostream>
using namespace std;

struct student{
    string name;
    double gpa;
    bool enrolled; 
};


int main (){

    student stduent1;
    stduent1.name = "Mahin";
    stduent1.gpa = 3.2;
    stduent1.enrolled = true;

    student stduent2;
    stduent2.name = "Tumpa";
    stduent2.gpa = 3.3;
    stduent2.enrolled = false;

    cout << stduent1.name << '\n';
    cout << stduent1.gpa << '\n';
    cout << stduent1.enrolled << '\n';

    cout << stduent2.name << '\n';
    cout << stduent2.gpa << '\n';
    cout << stduent2.enrolled << '\n';

    return 0;
}