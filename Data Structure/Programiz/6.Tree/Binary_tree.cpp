#include<iostream>
#include<stdlib.h>
using namespace std;

struct node{
    int data;
    struct node *left, *right;
};


struct node* newNode(int data){
    struct node *node = (struct node*)malloc(sizeof(struct node));
    node->data = data;
    node->left = node->right = NULL;
    return node;
}

void traversePreOrder(struct node *temp){
    if(temp != NULL){
        cout << " " << temp->data;
        traversePreOrder(temp->left);
        traversePreOrder(temp->right);
    }
}

void traverseInOrder(struct node *temp){
    if(temp!=NULL){
        traverseInOrder(temp->left);
        cout << " " << temp->data;
        traverseInOrder(temp->right);
    }
}

void traversePosterOrder(struct node *temp){
    if(temp !=NULL){
        traversePosterOrder(temp->left);
        traversePosterOrder(temp->right);
        cout << " " << temp->data;
    }
}

int main(){
    struct node *root = newNode(1);
    root->left = newNode(12);
    root->right= newNode(9);
    root->left->left = newNode(5);

    cout << "Preorder Traversal ";
    traversePreOrder(root);
    cout << "\nInorder Traversal ";
    traverseInOrder(root);
    cout << "\nPostorder Traversal ";
    traversePosterOrder(root);
    return 0;

}


