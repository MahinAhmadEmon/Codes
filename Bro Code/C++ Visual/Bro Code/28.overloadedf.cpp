#include <iostream>
using namespace std;
void bakepizza(){
    cout << "Here is ur pizza";
}
void bakepizza(string topping1){
    cout << "Here is ur  " << topping1 << " pizza!\n";
}
void bakepizza(string topping1, string topping2){
    cout << "Here is ur " << topping1 << " and " << topping2 <<" pizza!\n";
}

int main() {


bakepizza("pepperoni", "mushrooms");

    return 0;
}