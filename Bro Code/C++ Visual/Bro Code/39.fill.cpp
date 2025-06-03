#include <iostream>
using namespace std;

int main (){

    // fill() = Fills a range of elements wuth a specific value
    //          fill (begin, end , value)

    const int size  = 99;
    string foods[size];

    fill(foods, foods + (size/3), "pizza");
    fill(foods + (size/3), foods + (size/3)*2, "Burger");
    fill(foods + (size/3)*2, foods + size, "Hotdogs");

    for (string foods: foods){
        cout << foods << '\n';
    }  
    return 0;

}