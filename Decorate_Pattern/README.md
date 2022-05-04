## C# Decorate
The `Decorate` design pattern attaches additional responsibilities to an object dynamically. This pattern provide a flexible alternative to subclassing for extending functionality.

Frequency of use:  ![measure](https://www.dofactory.com/img/patterns/use-medium.jpg)  medium
## UML class diagram
A visualization of the classes and objects participating in this pattern.

![Class Diagram](https://www.dofactory.com/img/diagrams/net/decorator.png)

## 	Participants
The classes and objects participating in this pattern include:

- **Component** (`LibraryItem`)
	- defines the interface for objects that can have responsibilities added to them dynamically.
- **ConcreteComponent** (`Book`, `Video`)
	- defines an object to which additional responsibilities can be attached.
- **Decorator** (`Decorator`)
	- maintains a reference to a Component object and defines an interface that conforms to Component's interface.
- **ConcreteDecorator** (`Borrowable`)
	- adds responsibilities to the component.

## Structure of Console Code
### Structural code in C#
This structural code demonstrates the Decorator pattern which dynamically adds extra functionality to an existing object.

**Output**
```
ConcreteComponent.Operation()
ConcreteDecoratorA.Operation()
ConcreteDecoratorB.Operation()
```
### Real-world code in C#
This real-world code demonstrates the Decorator pattern in which *borrowable* functionality is added to existing library items (books and videos).

**Output**
```
Book ------
Author: Worley
Title: Inside ASP.NET
# Copies: 10

Video -----
Director: Spielberg
Title: Jaws
# Copies: 23
Playtime: 92


Making video borrowable:

Video -----
Director: Spielberg
Title: Jaws
# Copies: 21
Playtime: 92

borrower: Customer #1
borrower: Customer #2
```
### .NET Optimized code in C#
The .NET optimized code demonstrates the same code as above but uses more modern, built-in .NET features.
*Be Continued...*
		  
