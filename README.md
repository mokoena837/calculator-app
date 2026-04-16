# Calculator Application

## Overview

This project is a desktop calculator application developed using Visual Basic .NET with Windows Forms. It provides basic arithmetic functionality along with additional operations such as percentage, modulus, and memory functions. The application demonstrates event-driven programming and graphical user interface development in a .NET environment.

---

## Programming Language

The application is built using Visual Basic .NET (VB.NET), a programming language developed by Microsoft as part of the .NET framework. VB.NET is commonly used for developing Windows desktop applications due to its simplicity and strong integration with the Windows Forms framework.

---

## Features

The calculator supports the following operations:

- Addition
- Subtraction
- Multiplication
- Division
- Percentage calculation
- Modulus operation
- Memory functions (M+, M−)
- Decimal number input
- Clear/reset functionality

---

## Application Structure

The program uses a Windows Forms interface with buttons representing numbers and operations. User input is displayed in a text field and processed based on button click events.

### Key Components

- `firstNum` stores the first input value
- `secondNum` stores the second input value
- `operations` determines the selected arithmetic operation
- `operator_selector` tracks whether an operation has been selected
- `memory` stores values for memory functions

---

## How It Works

### Number Input

All numeric buttons share a single event handler. When a number button is clicked, its value is appended to the display unless the display currently shows zero.

### Operation Selection

When an operator button is clicked:
- The current value is stored as `firstNum`
- The display is reset
- The selected operation is stored in the `operations` variable
- The system waits for the second number input

### Calculation Execution

When the equals button is pressed:
- The second number is captured
- The program evaluates the selected operation
- The result is displayed in the output field

Division includes error handling for division by zero.

---

## Supported Operations Logic

The application uses integer constants to represent operations:

- 1 = Addition
- 2 = Subtraction
- 3 = Multiplication
- 4 = Division
- 5 = Percentage
- 6 = Modulus
- 7 = Memory Add (M+)
- 8 = Memory Subtract (M−)

A conditional structure evaluates these values to perform the correct calculation.

---

## Memory Functions

The calculator includes simple memory functionality:

- M+ adds the current value to memory
- M− subtracts the current value from memory
- The memory value is stored throughout the session

---

## User Interface

The application uses Windows Forms controls including:
- Buttons for digits and operations
- A text box for input and output display

Each button triggers an event handler that processes user input and updates the display accordingly.

---

## How to Run the Project

1. Open the project in Visual Studio 2022
2. Load the solution file (.sln)
3. Build the project
4. Run the application using the Start button

---

## Purpose of the Project

This project was developed as a beginner-level application to demonstrate:

- Event-driven programming in VB.NET
- Windows Forms application development
- Basic arithmetic logic implementation
- User interface interaction handling
- Simple memory storage concepts

---

## Author

Created by mokoena837
