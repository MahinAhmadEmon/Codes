#include <iostream>
#include <stack> 
using namespace std;

void printStackElements(stack<int> stack){
    while (!stack.empty()){
        cout << stack.top() << endl;
        stack.pop();
    }
}

int main(){

    // empty, size, push, pop, top
    stack<int>numbersStack;
    numbersStack.push(1);
    numbersStack.push(2);
    numbersStack.push(3);
    numbersStack.pop();

    printStackElements(numbersStack);

    // if(numbersStack.empty())
    //     cout << "Stack is Empty" << endl;
    // else
    //     cout << "stack is not empty" << endl;
    // cout <<"Stack size is " << numbersStack.size() << endl;

    system("pause>0");
} 
