#include <iostream>
using namespace std;

int main(){
    double B, d;
    cout << "Input Initial Battery Level and Decrease per minute: ";
    cin >> B;
    cin >> d;

    if(B <= 20.0){
        cout << "Below 20%" << endl;
        return 0;
    }

    if(d <= 0.0){
        cout << "Not possible" << endl;
        return 0;
    }

    double r = 1.0 - d / 100.0;
    if(r <= 0.0){
        cout << "Not possible" << endl;
        return 0;
    }

    int minutes = 0;
    double currBatt = B;
    while(currBatt > 20.0){
        currBatt *= r;
        minutes++;
    }

    if(currBatt > 20.0){
        cout << "There is more battery left" << endl;
    } else {
        cout << minutes << endl;
    }
    return 0;

}