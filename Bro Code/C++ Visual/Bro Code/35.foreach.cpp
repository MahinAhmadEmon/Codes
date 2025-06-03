#include <iostream>
using namespace std;

int main ()
{
    // foreach loop = loop that eases the traversal over an
    //                iterable data set

    //string students [] = {"Tumpa", "Mahin", "Sara", "Deeshan"};

    int grades [] = {65, 71, 22, 67};

    for (int grade : grades){
        cout << grade << '\n'; 
    }

    return 0;
}