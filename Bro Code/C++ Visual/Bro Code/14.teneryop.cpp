#include <iostream>
using namespace std;

int main ()
{
    // ternary operator ?: = replacement to an if/else statement
    // condition ? expression1 : expression2;

    //int grade = 50;
    //grade >= 60 ? cout << "You pass!" : cout << "You failed!";
    
    //int number = 9;
    //number % 2 ? cout << "ODD" : cout << "EVEN";
    

    bool hungry = true;

    //hungry ? cout << "You r hungry" :  cout << "You r full";
    cout << (hungry? "You r hungry" : "You r full");
    return 0;
}