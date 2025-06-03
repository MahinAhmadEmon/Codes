#include <iostream>
using namespace std;

int main ()
{
    //string students [] = {"Mahin", "Tumpa", "Sara","Deeshan"};
    char grades[] = {'A', 'B', 'C', 'D', 'F'};

    for (int i = 0; i < sizeof(grades)/sizeof(char); i++){

        cout << grades [i] << "\n";

    }


    return 0;
}