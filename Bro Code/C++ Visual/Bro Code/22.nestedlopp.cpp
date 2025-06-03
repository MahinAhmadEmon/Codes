#include<iostream>
using namespace std;
int main(){

    int rows;
    int columns;
    char symbol;

    cout << "How many Rows?: ";
    cin >> rows;
    cout << "How many Columns?: ";
    cin >> columns;

    cout << "Enter a symbol: ";
    cin >> symbol;

    
    for (int i = 1; i <= rows; ++i){
    cout << endl;
    for(int j = 1; j <= columns; ++j){
        cout << symbol;
    }
}
    return 0;
}