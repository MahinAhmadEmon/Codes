#include <iostream>
#include <ctime>
using namespace std;

int main (){
    srand(time(0));
    int randNum = rand() % 5 + 1;

    switch(randNum){
        case 1: cout << "You win a Mojo! \n";
        break;
        case 2: cout << "You win a Pizza! \n";
        break;
        case 3: cout << "You win a Ball! \n";
        break;
        case 4: cout << "You win a Bat! \n";
        break;
        case 5: cout << "You win a Milk! \n";
        break;
    }
 return 0;
}