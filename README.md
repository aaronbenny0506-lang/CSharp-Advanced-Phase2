# Simple Calculator (C#)

A console-based calculator built to practice loops, methods, and class structure in C#.

## Description

The app shows a menu and keeps running until the user chooses to exit. It performs the four basic arithmetic operations: addition, subtraction, multiplication, and division.

## Main methods/classes

- **`Calculator` class** (`Calculator.cs`) — holds the arithmetic logic as four methods:
  - `Add(a, b)`
  - `Subtract(a, b)`
  - `Multiply(a, b)`
  - `Divide(a, b)` — throws a `DivideByZeroException` if the second number is 0
- **`Program` class** (`Program.cs`) — the entry point:
  - Uses a `while` loop to keep showing the menu until the user picks "Exit"
  - Uses a `switch` statement to route the user's choice to the right `Calculator` method
  - `ReadNumber()` is a helper method that loops until valid numeric input is entered

## How to run

Requires the [.NET SDK](https://dotnet.microsoft.com/download).

```bash
dotnet run
```

## Example output

```
=== Simple Calculator ===

Choose an operation:
1. Add
2. Subtract
3. Multiply
4. Divide
5. Exit
Enter your choice (1-5): 1
Enter the first number: 4
Enter the second number: 6
Result: 4 + 6 = 10
```

## Notes on what I learned

- How to structure a program using a class (`Calculator`) that's separate from the entry point (`Program`).
- How methods with parameters and return types keep logic reusable and testable.
- How to use loops (`while`) to keep a console app running until the user asks to quit.
- How to handle invalid input and edge cases (like dividing by zero) with exceptions instead of letting the program crash.
