#include <iostream>
using namespace std;

string concatStrings(string string1, string string2);

int main(){

string firstname = "Mahin";
string lastname = "Ahmad";
string fullname = concatStrings (firstname, lastname);

cout << "Hello " << fullname;

    return 0;
}
string concatStrings(string string1, string string2){
    return string1 + " " + string2;
}
