#include<iostream>
using namespace std;

int main(){
    int arr[] = {20, 40, 60, 80, 100};
    int average = 0;
    int size = sizeof(arr) / sizeof(arr[0]);
    for(int i = 0; i < 5; i++){
        average += arr[i];
    }
    average = average / size;
    cout << average << endl;
    return 0;
}