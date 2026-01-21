marks = []
for i in range (1,6):
    mark = float(input(f"Enter mark {i}: "))
    marks.append(mark)
    
    print("Subject Marks: ")
    for i, mark in enumerate(marks, start=1):
        print(f"Subject {i}: {mark}")
        
    avg = sum(marks) / len(marks)
    print(f"Average Mark: {avg}")
    
if all(mark >= 50 for mark in marks):
    print("Result: PASS")
else:
    print("Result: FAIL")