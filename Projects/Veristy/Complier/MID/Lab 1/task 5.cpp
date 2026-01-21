#include<iostream>
using namespace std;

int main (){
    int n;
    cout << "No of elements: ";
    cin >> n;

    int arr[n];

    for(int i = 0; i < n; i++){
        cout << "Enter element " << i + 1 << ": ";
        cin >> arr[i];
    }

    int max = arr[0];
    int min = arr[0];

    for(int i = 1 ; i < n; i++){
        if(arr[i] > max){
            max = arr[i];
        }
        if(arr[i] < min){
            min = arr[i];
        }
    }

    cout << "max" <<max<< endl;
    cout << "min" <<min<< endl;
     return 0;
}