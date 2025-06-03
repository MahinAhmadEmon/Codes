#include <iostream>
using namespace std;

int main()
{
    //if statement = do something if a condition is true.
    //               if not, then dont do it.


    int age;

    cout << "Enter Your Age: ";
    cin >> age;
    
    if (age >= 100){
        cout << "You are to old to enter";
    }
    else if (age >= 18) {

        cout << "Welcome to the site!";

    }

    else if (age < 0) {
        cout << "You havnt been born yet";
    }

    else if (age >= 100){
        cout << "You are to old to enter";
    }
    else{
        cout << "You are not old enough";
    }


    return 0;
}