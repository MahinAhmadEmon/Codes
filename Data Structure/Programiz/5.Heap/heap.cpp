#include <iostream>
#include<vector>
using namespace std;

void swap( int *a, int *b){
    int temp = *a;
    *a = *b;
    *b = temp;
}

void heapify(vector<int> &hT, int i){
    int size = hT.size();
    int largest = i;
    int l = 2 * i + 1;
    int r = 2 * i + 2;
    if( l < size && hT[l] > hT[largest])
        largest = l;
    if( r < size && hT[r] > hT[largest])
        largest = r;
    if( largest != i){
        swap(&hT[i], &hT[largest]);
        heapify(hT, largest);
    }
}

void insert (vector<int> &hT, int newNum){
    hT.push_back(newNum);
    int current = hT.size() - 1;
    while  (current > 0 ){
        int parent = (current -1) /2;
        if(hT[current] > hT[parent]){
            swap(&hT[current], &hT[parent]);
        }else{
            break;
        }
    }
}

void deleteNode(vector<int> &hT, int num){
    int size = hT.size();
    int i;
    for(i = 0; i <size; i++){
        if(num == hT[i])
        break;
    }

    swap(&hT[i] , &hT[size -1]);
    hT.pop_back();

    size = hT.size();

    if( i < size){
        heapify(hT , i);
    }
}

void printArray(const vector<int> &hT){
    for(int num : hT){
        cout << num << " ";
        cout << "\n";
    }
} 

int main(){
    vector<int> heapTree;
    insert(heapTree, 3);
    insert(heapTree, 4);
    insert(heapTree, 9);
    insert(heapTree, 5);
    insert(heapTree, 2);

    cout << "Max-Heap array: ";
    printArray(heapTree);

    deleteNode(heapTree, 4);

    cout << "After deleting an element: ";
    printArray(heapTree);
    return 0;
}