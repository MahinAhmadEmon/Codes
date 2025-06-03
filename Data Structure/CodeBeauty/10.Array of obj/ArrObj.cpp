#include <iostream>
using namespace std;


class Student{
public:
    string Name;
    int Age;
    char Gender;
    float ProgrammingGrade;

Student(){}

Student(string name, int age, char gender, float programmingGrade){
        Name = name;
        Age = age;
        Gender = gender;
        ProgrammingGrade = programmingGrade;
    }

};


int main(){

    int luckyNumbers[5] = {1,3,5,13,21};

    Student students[3] = {
        {"Salina" , 28, 'f', 9.5},
        {"Elon" , 50, 'm', 10},
        {"Bill" , 60, 'm', 7}
    }; 

    // Student students[3];

    // for(int i = 0; i < 3; i++){
    //     cout << "STUDENT " << i << endl;
    //     Student s;
    //     cout << "Name: ";
    //     cin >> s.Name;
    //     cout << "Age: ";
    //     cin >> s.Age;
    //     cout << "Gender: ";
    //     cin >> s.Gender;
    //     cout << "Programming Grade: ";
    //     cin >> s.ProgrammingGrade; 

    //     students[i] = s;

    //     cout << "Programming Grade of 1st student is: " 
    //     << students[0].ProgrammingGrade;

    // }

    float sumOfGrades=0;
    for(int i=0;i<=3;i++){
        sumOfGrades+=students[i].ProgrammingGrade;
    }

    cout << "Average grade is " << sumOfGrades  / 3;

    
    cin.get();
}