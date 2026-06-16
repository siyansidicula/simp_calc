# Simple Calculator in C#

## Overview

This project is a simple console-based calculator developed using C#. It allows users to perform basic arithmetic operations such as addition, subtraction, multiplication, and division through a menu-driven interface.

The program demonstrates the use of classes, objects, methods, loops, conditional statements, and switch cases in C#.

---

## Features

* Addition of two numbers
* Subtraction of two numbers
* Multiplication of two numbers
* Division of two numbers
* Division-by-zero error handling
* Menu-driven user interface
* Continuous execution until the user chooses to exit

---

## Concepts Used

* Classes and Objects
* Methods
* Loops (`while`)
* Conditional Statements (`if`)
* Switch Case
* User Input and Output
* Exception Handling for Division by Zero

---

## Project Structure

### Calculator Class

The `Calculator` class contains methods for performing arithmetic operations:

* `Add()` – Returns the sum of two numbers.
* `Subtract()` – Returns the difference between two numbers.
* `Multiply()` – Returns the product of two numbers.
* `Divide()` – Returns the quotient of two numbers and checks for division by zero.

### Program Class

The `Program` class contains the `Main()` method, which:

1. Displays the calculator menu.
2. Accepts user input.
3. Calls the appropriate method from the `Calculator` class.
4. Displays the result.
5. Repeats until the user selects the Exit option.

---

## Sample Menu

```text
--- Simple Calculator ---
1. Add
2. Subtract
3. Multiply
4. Divide
5. Exit
```

---

## Sample Output

```text
--- Simple Calculator ---
1. Add
2. Subtract
3. Multiply
4. Divide
5. Exit

Choose an option: 1

Enter first number: 10
Enter second number: 20

Result: 30
```

---

## Learning Outcomes

By completing this project, you will understand:

* How to create and use classes in C#
* How methods improve code reusability
* How loops can repeatedly execute code
* How switch statements simplify decision-making
* How to handle basic user input and output

---
