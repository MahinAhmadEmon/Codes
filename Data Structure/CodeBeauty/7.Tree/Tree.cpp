#include<iostream>
using namespace std;

struct Node{

    int data;
    Node* left;
    Node* right;
};

Node* createNode(int data) {
    Node* newNode = new Node(); 
    newNode->data = data;       
    newNode->left = nullptr;   
    newNode->right = nullptr;
    return newNode;             
}


int main(){
    //lvl1
    Node* root= createNode(1);
    //lvl2
    root->left = createNode(2);
    root->right = createNode(3);
    //lvl3
    root->left->left = createNode(4);
    root->left->right = createNode(5);
    root->right->left = createNode(6);
    root->right->right = createNode(7);
    //lvl4
    root->left->right->left = createNode(9);
    root->right->right->left = createNode(15);

    
    cin.get();
}