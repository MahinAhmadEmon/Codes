#include <iostream>
using namespace std;

class Stove{
    private:
        int temp = 0;
    public:
    Stove(int temp){
        setTemp(temp);
    }
    int getTemp(){
        return temp;
    }
    void setTemp(int x){
        if(temp < 0){
            temp = 0;
        }
        else if(temp >= 10){
            temp = 10;
        }
        else{
            temp = x;
        }
    }
    
};

int main (){

    // Abstractraction = hiding unnecessary data from outside a class
    // getter = function that makes a private attribute READABLE
    // setter = function that makes a private attribute WRITEABKLE

    Stove stove(0);

    //stove.setTemp(6);

    cout << "The Temp is: " << stove.getTemp();
    return 0;
}