#include <iostream>
using namespace std;

int myNum = 3;

void printNum(){
    int myNum = 2;
    cout << ::myNum;
}

int main (){

    // lolac varibles = decalred inside a fnction or block {}
    // global variables = declared outside of all functions
    int myNum = 1;

    printNum();
    cout << ::myNum << endl;

    return 0;
}
