#include <iostream>
#include <string.h>
using namespace std;

class Student {
public: 
    string Name;
    int Age;
    char Gender;
    float ProgrammingGrade;    
};

void printStudents(Student* students, int size){
    for(int i=0; i<size; i++){
        cout << "STUDENT " << i+1 << "\t";
        cout << students[i].Name << "\t"; 
        cout << students[i].Age << "\t";
        cout << students[i].Gender << "\t";
        cout << students[i].ProgrammingGrade << "\n";
    }

}


int main(){

    int size;
    cout << "Number of students: ";
    cin >> size;

    Student* students = new Student[size];

    for(int i=0; i<size; i++){
        cout << "STUDENT " << i+1 << endl;

        Student s;
        cout << "Name: ";
        cin >> s.Name;
        cout << "Age: ";
        cin >> s.Age;
        cout << "Gender: ";
        cin >> s.Gender;
        cout << "Programming grade: ";
        cin >> s.ProgrammingGrade;

        students[i] = s;
    }

    char choice;
    cout <<  "Do u want a bigger array?";
    cin >> choice;
    if(choice == 'n' || choice == 'N'){
        delete [] students;
        return 0;
    }

    int newSize;
    cout << "Enter new size: ";
    cin >> newSize;

    Student* newStudent  = new Student[newSize];
    memcpy(newStudent, students, sizeof(Student) * size);
    // for(int i = 0; i<size; i++){
    //     newStudent[i] = students[i];
    // }
    delete[]students;
    students = newStudent;

    for(int i=size; i<newSize; i++){
        cout << "STUDENT " << i+1 << endl;

        Student s;
        cout << "Name: ";
        cin >> s.Name;
        cout << "Age: ";
        cin >> s.Age;
        cout << "Gender: ";
        cin >> s.Gender;
        cout << "Programming grade: ";
        cin >> s.ProgrammingGrade;

        students[i] = s;
    }

    printStudents(students, size);


     
    cin.get();

}