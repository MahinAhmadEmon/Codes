#include <iostream>
#include <map>
#include <string>
#include <list>
using namespace std;

int main (){

    map<string, list<string>> pokedex;

    list<string> pikachuAttacks{"shock", "whip" , "qucik attack"};
    list<string> charmanderAttacks{"flame", "scary face"};
    list<string> chikoritaAttacks{"razor" , "whip" , "poison"};

    pokedex.insert(pair<string, list<string>>("Pikachu", pikachuAttacks));
    pokedex.insert(pair<string, list<string>>("Charmander", charmanderAttacks));
    pokedex.insert(pair<string, list<string>>("Chikorita", chikoritaAttacks));

    for (auto pair : pokedex){
        cout << pair.first << " - ";

        for (auto attack : pair.second)
            cout << attack << " ,  ";

            cout << endl;
        
    }
    system("pause>0");
}