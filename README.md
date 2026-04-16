# Calculator Application (Group Project)

![Interface](My%20Project/Screenshot%202026-04-16%20085823.png)

## Overview

This project is a desktop calculator application developed as a group assignment using Visual Basic .NET (VB.NET) with Windows Forms. It provides basic arithmetic functionality, along with additional features such as percentage calculations, modulus operations, and memory functions. The application demonstrates event-driven programming and graphical user interface (GUI) development within the .NET framework.

---

## Programming Language

The application was built using Visual Basic .NET (VB.NET), a Microsoft programming language designed for the .NET framework. VB.NET is commonly used for Windows desktop applications due to its simplicity and strong integration with Windows Forms.

---

## Features

The calculator supports the following operations:

- Addition
- Subtraction
- Multiplication
- Division
- Percentage calculation
- Modulus operation
- Memory functions (M+ and M−)
- Decimal number input
- Clear/reset functionality

---

## Application Structure

The program uses a Windows Forms interface with buttons for numbers and operations. User input is displayed in a text box and processed through button click events.

### Key Components

- `firstNum` → stores the first input value  
- `secondNum` → stores the second input value  
- `operations` → determines the selected arithmetic operation  
- `operator_selector` → tracks whether an operation has been selected  
- `memory` → stores values for memory functions  

---

## How It Works

### Number Input
All numeric buttons share a single event handler. When a number is clicked, it is appended to the display unless the display currently shows zero.

### Operation Selection
When an operator button is clicked:
- The current value is stored as `firstNum`
- The display is cleared
- The selected operation is stored in `operations`
- The system waits for the second number input

### Calculation Execution
When the equals button is pressed:
- The second number is captured
- The selected operation is evaluated
- The result is displayed

Division includes error handling for division by zero.

---

## Supported Operations Logic

Operations are represented using integer values:

- 1 = Addition  
- 2 = Subtraction  
- 3 = Multiplication  
- 4 = Division  
- 5 = Percentage  
- 6 = Modulus  
- 7 = Memory Add (M+)  
- 8 = Memory Subtract (M−)  

A conditional structure is used to execute the correct operation.

---

## Memory Functions

- **M+** adds the current value to memory  
- **M−** subtracts the current value from memory  
- Memory remains stored throughout the session  

---

## User Interface

The application uses Windows Forms controls such as:
- Buttons for digits and operations  
- A textbox for input and output display  

Each button triggers an event handler that processes user input and updates the display.

---

## How to Run the Project

1. Open the project in Visual Studio 2022  
2. Load the solution file (.sln)  
3. Build the project  
4. Run the application using the Start button  

---

## Purpose of the Project

This group project was developed to demonstrate:
- Event-driven programming in VB.NET  
- Windows Forms development  
- Implementation of arithmetic logic  
- User interface interaction handling  
- Basic memory storage concepts  

---

## Authors

This project was developed as a group assignment by the team members of **Mokoena837**.
