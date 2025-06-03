#include <iostream>

namespace first{
    int x = 1;
}
namespace second{
    int x = 2;
}
int main() {
using namespace first;
    

    std::cout << x;

    return 0;
    
}