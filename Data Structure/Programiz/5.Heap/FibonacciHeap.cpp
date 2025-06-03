#include<iostream>
#include<cstdlib>
#include<cmath>
using namespace std;   

struct node {
    int n;
    int degree;
    node *parent;
    node *child;
    node* left;
    node* right;
    char mark;
    char C;
};

class FibonacciHeap {
    private:
    int nH;

    node *H;

    public:
    node *InitializeHeap();
    int Fibonnaci_link(node *, node *, node *);
    node *Create_node(int);
    node *Insert(node *, node *);
    node *Union(node *, node *);
    node *Extract_min(node *);
    int consolidate(node *);
    int Display(node *);
    node *Find(node *, int);
    int Decrease_key(node *, int , int);
    int Delete_key(node *, int);
    int Cut(node *, node *, node *);
    int Cascase_cut(node * , node *);
    FibonacciHeap(){ H = InitializeHeap(); }
};

node *FibonacciHeap::InitializeHeap(){
    node *np;
    np = NULL;
    return np;
}

node *FibonacciHeap::Create_node(int value){
    node *x = new node;
    x->n = value;
    return x;
}

node *FibonacciHeap::Insert(node *H, node *x){
    x->degree = 0;
    x->parent = NULL;
    x->child = NULL;
    x->left = x;
    x->right = x;
    x->mark = 'F';
    x->C = 'N';

    if( H != NULL){
        (H->left) -> right = x;
        x->right = H;
        x->left = H->left;
        H->left = x;
        if( x->n < H->n)
            H = x;
    }else{
        H = x;
    }
    nH = nH +1;
    return H;
}

int FibonacciHeap::Fibonnaci_link(node *H1, node *y, node *z){
    (y->left)->right = y->right;
    (y->right)->left = y->left;
    if( z->right == z)
        H1 = z;
    y->left = y;
    y->right = y;
    y->parent = z;
    if( z->child == NULL)
        z->child = y;
    y->right = z->child;
    y->left = (z->child)->left;
    ((z->child)->left)->right = y;
    (z->child)->left = y;
    if( y->n < (z->child)->n)
        z->child = y;
    z->degree++;
}

node *FibonacciHeap::Union(node *H1, node *H2){
    node *np;
    node *H = InitializeHeap();
    H = H1;
    (H->left)->right = H2;
    (H2->left)->right = H;
    np = H->left;
    H->left = H2->left;
    H2->left = np;
    return H;
}

int FibonacciHeap::Display(node *H){
    node *p = H;
    if( p == NULL){
        cout<<"The Heap is Empty"<<endl;
        return 0;
    }
    cout<<"The root nodes of Heap are: "<<endl;
    do{
        cout<<p->n;
        p = p->right;
        if( p != H){
            cout<<"-->";
        }
    }while(p != H && p->right != NULL);
    cout<<endl;
}

node *FibonacciHeap::Extract_min(node *H1){
    node *p;
    node *ptr;
    node *z = H1;
    p = z;
    ptr = z;
    if( z == NULL){
        cout<<"The heap is empty"<<endl;
        return p;
    }
    node *x;
    node *np;
    x = NULL;
    if( z->child != NULL){
        x = z->child;
        np = x;
        do{
            ptr = x->right;
            (H1->left)->right = x;
            x->right = H1;
            x->left = H1->left;
            H1->left = x;
            if( x->n < H1->n)
                H1 = x;
            x->parent = NULL;
            x = ptr;
        }while(ptr != np);
    (z->left)->right = z->right;
    (z->right)->left = z->left;
    H1 = z;
    if( z == z->right && z->child == NULL)
        H = NULL;
    else{
        H1 = z->right;
        consolidate(H1);
    }
    nH = nH -1;
    }
    return p;
}


int FibonacciHeap::consolidate(node *H1){
    int d, i;
    float f = (log(nH))/(log(2));
    int D = f;
    node *A[D];
    for( i = 0; i <= D; i++)
        A[i] = NULL;
    node *x = H1;
    node *y;
    node *np;
    node *pt = x;
    do{
        pt = pt->right;
        d = x->degree;
        while( A[d] != NULL){
            y = A[d];
            if( x->n > y->n){
                np = x;
                x = y;
                y = np;
            }
            if( y == H1)
                H1 = x;
            Fibonnaci_link(H1, y, x);
            if( x->right == x)
                H1 = x;
            A[d] = NULL;
            d = d + 1;
        }
        A[d] = x;
        x = x->right;
    }while(x != H1);
    H = NULL;
    for( int j = 0; j <= D; j++){
        if( A[j] != NULL){
            A[j]->left = A[j];
            A[j]->right = A[j];
            if( H != NULL){
                (H->left)->right = A[j];
                A[j]->right = H;
                A[j]->left = H->left;
                H->left = A[j];
                if( A[j]->n < H->n)
                    H = A[j];
            }else{
                H = A[j];
            if( H == NULL)
                H = A[j];
            else if( A[j]->n < H->n)
                H = A[j];
            }
        }
    }
}

int FibonacciHeap::Decrease_key(node *h1, int x, int k){
    node *y;
    if( H == NULL){
        cout<<"The Heap is Empty"<<endl;
        return 0;
    }
    node *ptr = Find(H, x);
    if( ptr == NULL){
        cout<<"The Node is not found"<<endl;
        return 1;
    }
    if( ptr->n < k){
        cout<<"Entered key greater than current key"<<endl;
        return 0;
    }
    ptr->n = k;
    y = ptr->parent;
    if( y != NULL && ptr->n < y->n){
        Cut(H, ptr, y);
        Cascase_cut(H, y);
    }
    if( ptr->n < H->n)
        H = ptr;
    return 0;
}

int FibonacciHeap::Cut(node *H1, node *x, node *y)

{
  if (x == x->right)
    y->child = NULL;
  (x->left)->right = x->right;
  (x->right)->left = x->left;
  if (x == y->child)
    y->child = x->right;
  y->degree = y->degree - 1;
  x->right = x;
  x->left = x;
  (H1->left)->right = x;
  x->right = H1;
  x->left = H1->left;
  H1->left = x;
  x->parent = NULL;
  x->mark = 'F';
}

int FibonacciHeap::Cascase_cut(node *H1, node *y) {
    node *z = y->parent;
    if (z != NULL) {
      if (y->mark == 'F') {
        y->mark = 'T';
      } else
  
      {
        Cut(H1, y, z);
        Cascase_cut(H1, z);
      }
    }
  }

  node *FibonacciHeap::Find(node *H, int k) {
    node *x = H;
    x->C = 'Y';
    node *p = NULL;
    if (x->n == k) {
      p = x;
      x->C = 'N';
      return p;
    }
  
    if (p == NULL) {
      if (x->child != NULL)
        p = Find(x->child, k);
      if ((x->right)->C != 'Y')
        p = Find(x->right, k);
    }
  
    x->C = 'N';
    return p;
  }
  
  // Deleting key
  int FibonacciHeap::Delete_key(node *H1, int k) {
    node *np = NULL;
    int t;
    t = Decrease_key(H1, k, -5000);
    if (!t)
      np = Extract_min(H);
    if (np != NULL)
      cout << "Key Deleted" << endl;
    else
      cout << "Key not Deleted" << endl;
    return 0;
  }
  
  int main() {
    int n, m, l;
    FibonacciHeap fh;
    node *p;
    node *H;
    H = fh.InitializeHeap();
  
    p = fh.Create_node(7);
    H = fh.Insert(H, p);
    p = fh.Create_node(3);
    H = fh.Insert(H, p);
    p = fh.Create_node(17);
    H = fh.Insert(H, p);
    p = fh.Create_node(24);
    H = fh.Insert(H, p);
  
    fh.Display(H);
  
    p = fh.Extract_min(H);
    if (p != NULL)
      cout << "The node with minimum key: " << p->n << endl;
    else
      cout << "Heap is empty" << endl;
  
    m = 26;
    l = 16;
    fh.Decrease_key(H, m, l);
  
    m = 16;
    fh.Delete_key(H, m);
}








