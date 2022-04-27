## C# Bridge
The `Bridge` design pattern decouples an abstraction from its implementation so that the two can vary independently.

Frequency of use:  ![measure](https://www.dofactory.com/img/patterns/use-medium-low.jpg)  medium-low
## UML class diagram
A visualization of the classes and objects participating in this pattern.

![Class Diagram](https://www.dofactory.com/img/diagrams/net/bridge.png)

## 	Participants
The classes and objects participating in this pattern include:

- **Abstraction** (`BusinessObject`)
	- defines the abstraction's interface.
	- maintains a reference to an object of type Implementor.
- **RefinedAbstraction** (`CustomersBusinessObject`)
	- extends the interface defined by Abstraction.
- **Implementor** (`DataObject`)
	- defines the interface for implementation classes. This interface doesn't have to correspond exactly to Abstraction's interface; in fact the two interface can be quite different. Typically, the Implementation interface provides only primitive operations, and Abstraction defines higher-level operations based on these primitives.
- **ConcreteImplementor** (`CustomersDataObject`)
	- implements the Implementor interface and defines its concrete implementation.

## Structure of Console Code
### Structural code in C#
This structural code demonstrates the Abstract Factory pattern creating parallel hierarchies of objects. Object creation has been abstracted and there is no need for hard-coded class names in the client code.

**Output**
```
ConcreteImplementorA Operation
ConcreteImplementorB Operation
```
### Real-world code in C#
This real-world code demonstrates the creation of different animal worlds for a computer game using different factories. Although the animals created by the Continent factories are different, the interactions among the animals remain the same.

**Output**
```
Jim Jones
Samual Jackson
Allen Good

------------------------
Customer Group: Chicago
Jim Jones
Samual Jackson
Allen Good
Ann Stills
Lisa Giolani
Henry Velasquez
------------------------
```
### .NET Optimized code in C#
The .NET optimized code demonstrates the same code as above but uses more modern, built-in .NET features.
*Be Continued...*
		  
