#include <iostream>
#include <stdlib.h>

using namespace std;

#define MAX 10
int size = 0;

struct Stack
{
    int items[MAX];
    int top;
};

typedef struct Stack st;

void createEmptyStack(st *s){
     s->top = -1;
}

int isfull(st *s){
    if(s-> top == MAX-1)
    return 1;
    else 
    return 0;
}

int isempty(st *s){
    if(s->top == -1)
    return 1;
    else 
    return 0;
}

void push (st *s, int newitem){
    if(isfull(s)){
        cout << "STACK FULL";
    }else{
        s->top++;
        s->items[s->top] = newitem;
    }
    size++;
}

void pop(st *s){
    if (isempty(s)){
        cout << " STACK EMPTY " << endl;
    }else {
        cout << "Item  popped= " << s->items[s->top];
        s->top--;
    }
    size--;
    cout << endl;
}

void printStack(st *s){
    cout << "Stack: ";
    for(int i = 0 ;i < size ; i++){
        cout << s->items[i] << " ";
    }
    cout << endl;
}

int main(){
    int ch;

    st *s = (st *)malloc(sizeof(st));

    createEmptyStack(s);

    push(s, 1);
    push(s, 2);
    push(s, 3);

    printStack(s);

    pop(s);

    cout << "After popping out";
    printStack(s);
}










