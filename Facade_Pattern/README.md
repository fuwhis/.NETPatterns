## C# Facade 
The `Facade` design pattern provides a unified interface to a set of interfaces in a subsystem. This pattern defines a higher-level interface that makes the subsystem easier to use.

Frequency of use:  ![measure](https://www.dofactory.com/img/patterns/use-high.jpg)  high
## UML class diagram
A visualization of the classes and objects participating in this pattern.

![Class Diagram](https://www.dofactory.com/img/diagrams/net/facade.png)

## 	Participants
The classes and objects participating in this pattern include:

- **Facade** (`MortgageApplication`)
	- knows which subsystem classes are responsible for a request.
	- delegates client requests to appropriate subsystem objects.
- **Subsystem classes** (`Bank`, `Credit`, `Loan`)
	- implement subsystem functionality.
	- handle work assigned by the Facade object.
	- have no knowledge of the facade and keep no reference to it.

## Structure of Console Code
### Structural code in C#
This structural code demonstrates the Facade pattern which provides a simplified and uniform interface to a large subsystem of classes.

**Output**
```
MethodA() ----
SubSystemOne Method
SubSystemTwo Method
SubSystemFour Method

MethodB() ----
SubSystemTwo Method
SubSystemThree Method
```
### Real-world code in C#
This real-world code demonstrates the Facade pattern as a MortgageApplication object which provides a simplified interface to a large subsystem of classes measuring the creditworthiness of an applicant..

**Output**
```
Ann McKinsey applies for $125,000.00 loan

Check bank for Ann McKinsey
Check loans for Ann McKinsey
Check credit for Ann McKinsey

Ann McKinsey has been Approved
```
### .NET Optimized code in C#
The .NET optimized code demonstrates the same code as above but uses more modern, built-in .NET features.
*Be Continued...*
		  
