#include <iostream>
using namespace std;
int main () 
{
    // switch = alternative to using many "else if" statements
    //          comepare one value against matching cases

    char grade;

    cout << "What letter grade?: ";
    cin >> grade;

    switch(grade){
        case 'A':
        cout << "You did great";
        break;
        case 'B':
        cout << "You did good";
        break;
        case 'C':
        cout << "You did OK";
        break;
        case 'D':
        cout << "You did not good";
        break;
        case 'F':
        cout << "You did not well";
        break;
        default:
        cout << "Please only Enter (A, B, C, D, F)";
    }


    return 0;
}