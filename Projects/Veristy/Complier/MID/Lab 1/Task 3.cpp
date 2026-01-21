#include<iostream>
using namespace std;

int main (){
    int n;
    cout << "Number of students: ";
    cin >> n;

    string names[n];
    int marks[n];

    for(int i = 0; i < n; i++){
        cout << "Enter student name" << endl;
        cin >> names[i];
        cout << "Enter student marks" << endl;
        cin >> marks[i];
    }

    cout << "Total students: " << n << endl;
    for (int i = 0; i < n; i++) {
        cout << "Student " << i + 1 << ": " << names[i] << " ," << " Marks: " << marks[i] << endl;
    }
    return 0;
}
