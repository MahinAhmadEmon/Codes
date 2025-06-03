#include <iostream>
using namespace std;

int main(){

    // Null value = a special value that means something has no value.
    //              When a pointer is holding a null value,
    //              that pointer is not pointing at anything (null pointer)

    // nullptr = keyword represetns null pointer literal
    
    // nullptrs are helpful when determing if an address
    // was successfully assigned to a pointer

    // When using pointers, be careful that your code isn't
    // derefenceing nullptrs assigned to a pointing to free memory
    // this will cause undefined behavior


    int  *pointer = nullptr;
    int x = 123;
    pointer = &x;

    if(pointer == nullptr){
        cout << "Addess was not assigned!\n";
    }
    else{
        cout << "address was assigned!\n";
    }
    return 0;
}
