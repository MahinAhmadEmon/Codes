employee = []

for i in range (5):
    print("Enter details of employee ", i+1)
    id = input("Enter ID: ")
    salary = input("Enter Salary: ")
    
    
    if salary > 100000:
        grade = "Class A"
    elif 50000 < salary <= 100000:
        grade = "Class B"
    elif 20000 < salary <= 50000:
        grade = "Class C" 
    else:
        grade = "Low Grade"
        
        print("\n--- Employee Details ---")
for emp in employee:
    print(f"ID: {emp['ID']}, Salary: {emp['Salary']}, Grade: {emp['Grade']}")