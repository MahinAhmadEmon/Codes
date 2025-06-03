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

void printTree1(Node* root){ //Pre-order

    if(root == nullptr) return;

    cout << root->data << endl;
    printTree1(root->left);
    printTree1(root->right);

}

void printTree2(Node* root){ //In-order

    if(root == nullptr) return;

    printTree2(root->left);
    cout << root->data << endl;
    printTree2(root->right);

}

void printTree3(Node* root){ //Post-order

    if(root == nullptr) return;

    printTree3(root->left);
    printTree3(root->right);
    cout << root->data << endl;

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

    //printTree1(root);
    //printTree2(root);
    printTree3(root);

    
    cin.get();
}