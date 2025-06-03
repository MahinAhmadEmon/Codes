#include <iostream>
using namespace std;

int main ()
{

    //sizeof() = determines the size in bytes of a:
    //           variables, data types, class, objects, etc.

    string name = "Bro COde is mid";
    double gpa = 2.5;
    char grade = 'F';
    bool student = true;
    char grades[] = {'A', 'B', 'C' , 'D', 'F'};
    string students [] = {"Tumpa", "Mahin", "Sara", "Deeshan"};

    cout << sizeof(students)/sizeof(string) << " elements\n";

    return 0;

}