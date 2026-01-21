#include<iostream>
using namespace std;

int main(){
    cout << "Enter mobile number: ";
    string mbl;
    cin >> mbl;
    cout << mbl;

    if (mbl.length == 11){
        cout << "The length in not 11 digit Invalid";
    }
    else(mbl.at(0) == 0);
    {
        cout << " It starts with 0. Invalid";
    }

    return 0;
}