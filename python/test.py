# Declare a variable and get an input of a number
number = int(input("Enter a number: "))

# If number > 0 output "The number is positive"
# Else if number < 0 "... negative"
# Else 0
if number > 0:
    print("The number is positive!")
elif number < 0:
    print("The number is negative!")
else:
    print("The number is '0'!")

# Write a loop that prints out numbers 0 to 20
for i in range(21):
    print(i)