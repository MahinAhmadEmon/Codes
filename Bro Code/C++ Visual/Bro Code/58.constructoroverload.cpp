#include <iostream>
using namespace std;

class Pizza{
    public:
        string topping1;
        string topping2;

    Pizza(string x){
        topping1 = x;  
    }
    Pizza(string x, string y){
        topping1 = x;
        topping2 = y;
    }
    Pizza(){

    }
};

int main (){

    Pizza pizza1("Pepperoni");
    Pizza pizza2("Pepperoni" , "Mushroom");
    Pizza pizza3;

    cout << pizza2.topping1 << endl;
    cout << pizza2.topping2 << endl; 

    return 0;
}