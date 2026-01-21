//using c++ create a function which will check 
//if an expression which has at most 2 operators on the 
//right side is valid or invalid. example: A = X+Y/Z is a 
//valid on the other hand A+B = X+Y and A = XY+Z is not valid

#include<iostream>
using namespace std;

bool checkExpression(string expression){
    int eq = expression.find('=');

    if (eq == -1 || eq == 0 || eq == expression.length() - 1) {
        return false;
    }
    
    string left = expression.substr(0, eq);
    string right = expression.substr(eq + 1);

    if(left.size() != 1 || !isalpha(left[0]))
    return false; 

    int opCount = 0;

    for (int i = 0; i < right.size(); i++) {
        char ch = right[i];

    if (ch == '+' || ch == '-' || ch == '*' || ch == '/')
        opCount++;

    if (i > 0 && isalpha(right[i]) && isalpha(right[i - 1]))
        return false;
        if (opCount > 2)
        return false;
    }

    return true;
}

int main() {
    string exp;
    cout << "Enter expression: ";
    getline(cin, exp);

    if (checkExpression(exp))
        cout << "Valid";
    else
        cout << "Invalid";

    return 0;
}
