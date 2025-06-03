#include <iostream>
#include <iomanip>
using namespace std;


void showBalance(double balance){
    cout << "Your current balance is: $" << setprecision(2) << fixed << balance << endl;
}
double deposit(){
    double amount = 0;
    cout << "Enter amount to be deposited: ";
    cin >> amount;
    if(amount > 0){
    return amount;
    }else{
        cout << "Invalid \n";
        return 0;
    }
}
double withdraw(double balance){
    double amount = 0;
  cout << "Enter amount to be withdrawn: ";
  cin >> amount;
  if (amount > balance){
    cout << "You dont have that\n";
    return 0;
  }else if (amount < 0){
    cout << "That's not a valid amount\n";
    return 0;
  }
  else{
    return amount;
  }
}

int main ()
{
    double balance = 0;
    int choice = 0;
    do{
    cout << "Enter your choice: \n";
    cout << "1. Show Balance \n";
    cout << "2. Deposite Money \n";
    cout << "3. Withdraw Money\n";
    cout << "4. Exit\n";

    cin >> choice;
    cin.clear();
    fflush(stdin);

    switch (choice){
        case 1: showBalance(balance);
        break;
        case 2: balance += deposit();
                showBalance(balance);
        break;
        case 3: balance -= withdraw(balance);
                showBalance(balance);
        break;
        case 4: cout << "Thanks\n";
        break;
        default:cout <<"Invalid\n";
        break;
    }
    }while(choice != 4);
    
    return 0;
}