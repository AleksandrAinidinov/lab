# Comparing Python and C# Syntax

## Developer

- **Name**: Aleksandr Ainidinov 
- **Student ID**:8905450
- **Class**: PROG2390 - Small Business Solutions - Sec4 
- **Date**: 2025-03-11 
- **GitHub Repository**: [Comparing Python and C# Syntax Repository](https://github.com/AleksandrAinidinov/lab)  

---

This lab explores the differences between Python and C# by implementing a simple program that:
- Accepts user's input number.
- Determines whether the number is positive, negative, or zero using 'if else' statements.
- Iterates through numbers from `0` to `20` using a loop.

---

## Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/AleksandrAinidinov/lab.git
   cd lab
   ```

2. **Install Python**:
   Ensure you have Python installed, then run:
   ```bash
   python test.py
   ```

3. **Install Dotnet**:
   Ensure you have Dotnet installed, then run:
   ```bash
   dotnet build
   dotnet run
   ```

---

## Comparing Python Syntax with C#
1. General Syntax Difficulty:
- Python: Easier to read and understand, as its syntax is very close to regular English.
- C#: More structured and explicit, which makes it harder to grasp initially.

2. Variable Declaration:
- Python: Does not require declaring variable types.
- C#: Requires declaring variable types (e.g., ```int number = 0```); otherwise, it will give an error.

3. Reading User Input and Printing out Data:
- Python: Uses ```input()``` and ```print()```.
- C#: Uses ```Console.ReadLine()``` and ```Console.Write()``` / ```Console.WriteLine()```.

4. Parsing User Input:
- Python: Uses ```int()``` to convert input to an integer.
- C#: Uses ```Convert.ToInt32()``` or ```int.Parse()```.

5. Conditions:
- Python - Uses ```if/elif/else```, does not require parentheses around condition.
- C# - Uses ```if/else if/else```, requires parentheses around conditions.

6. Loops:
- Python - Uses ```for i in range(n + 1):```, right end of range is not included.
- C# - Uses ```for (int i = 0; i <= n; i++)```, right end of range is included if ```<=``` is used.
---

## License

This project is licensed under the MIT License. You are free to use, modify, and distribute it as permitted under this license.