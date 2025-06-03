#include<iostream>
using namespace std;

int main(){

    //total, avg, inTwoYears
    
    float monthArray[12];
    float total = 0;
    for(int i = 0;i<=11; i++){
        cout << "Enter Amount: " << i+1 << endl;
        cin >> monthArray[i];
        total+= monthArray[i];
    }

    
    float avg = total/12;
    float inTwoYears = avg * 24;

    cout << "Total = " << total << endl;
    cout << "Avarage = " << avg << endl;
    cout << "In Two Years = " << inTwoYears << endl;


    system("pause>0");
}