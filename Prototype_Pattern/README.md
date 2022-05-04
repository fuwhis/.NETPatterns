## C# Prototype
The `Prototype` design pattern specifies the kind of objects to create using a prototypical instance, and create new objects by copying this prototype.

Frequency of use:  ![measure](https://www.dofactory.com/img/patterns/use-medium.jpg)  medium
## UML class diagram
A visualization of the classes and objects participating in this pattern.

![Class Diagram](https://www.dofactory.com/img/diagrams/net/prototype.png)

## 	Participants
The classes and objects participating in this pattern include:

- **Prototype** (`ColorPrototype`)
	- declares an interface for cloning itself.
- **ConcretePrototype** (`Color`)
	- implements an operation for cloning itself.
- **Client** (`ColorManager`)
	- creates a new object by asking a prototype to clone itself.

## Structure of Console Code
### Structural code in C#
This structural code demonstrates the Prototype pattern in which new objects are created by copying pre-existing objects (prototypes) of the same class.

**Output**
```
Cloned: I
Cloned: II
```
### Real-world code in C#
This real-world code demonstrates the Prototype pattern in which new Color objects are created by copying pre-existing, user-defined Colors of the same type.

**Output**
```
Cloning color RGB: 255,  0,  0
Cloning color RGB: 128,211,128
Cloning color RGB: 211, 34, 20
```
### .NET Optimized code in C#
The .NET optimized code demonstrates the same code as above but uses more modern, built-in .NET features.
*Be Continued...*
		  
