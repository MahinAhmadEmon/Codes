#include <iostream>
#include <vector>

//typedef std::vector<std::pair<std::string, int>> pairlist_t;
using test_t = std::string;
using number_t = int;

int main () {

    test_t firstName = "Bro";
    number_t age = 21;

    std::cout << firstName << '\n';
    std::cout << age << '\n';

    return 0;
}