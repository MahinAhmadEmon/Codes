#include <iostream>
using namespace std;
int main(){
    string name;

    while(name.empty()){
        cout << "Enter Your name: ";
        getline(cin, name);
    }
    cout << "Hello "<< name;

}