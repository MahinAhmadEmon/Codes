#include<iostream>
using namespace std;

int main(){
    int n;

    cout<<"Enter the number: " << endl;
    cin >> n;

    int arr[n];

    for (int i = 0; i < n; i++){
        cout << "Enter the element: " << i+1 << endl;
        cin >> arr[i];
    }

    cout << "Reverse order: " << endl;
    for (int j = n-1; j >= 0; j--){
        cout << arr[j] << endl;
    }


    return 0;

}
