#include <iostream>
#include <string>
using namespace std;

int main(){
    string s;
    cout << "Input a string: ";
    getline(cin, s);

    int vowel = 0;
    int consonant = 0;
    for(char c : s){
        if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')) {
        char lower_c = c;
        if (lower_c >= 'A' && lower_c <= 'Z') lower_c = lower_c - 'A' + 'a';
        if (lower_c == 'a' || lower_c == 'e' || lower_c == 'i' || lower_c == 'o' || lower_c == 'u') {
            vowel++;
        } else {
            consonant++;
        }
    }
    cout << "Vowels: " << vowel << endl;
    cout << "Consonants: " << consonant << endl;
    return 0;
}
}