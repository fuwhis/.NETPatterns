## C# Singleton
The `Singleton` design pattern ensures a class has only one instance and provide a global point of access to it.
Frequency of use:
## UML class diagram
A visualization of the classes and objects participating in this pattern.

![Class Diagram](https://www.dofactory.com/img/diagrams/net/Singleton.png)

## 	Participants
The classes and objects participating in this pattern include:

-  **Singleton** (`LoadBalancer`)
	- defines an Instance operation that lets clients access its unique instance. Instance is a class operation.
	- responsible for creating and maintaining its own unique instance.

## Structure of Console Code
### Structural code in C#
This structural code demonstrates the Singleton pattern which assures only a single instance (the singleton) of the class can be created.

### Real-world code in C#
This real-world code demonstrates the Singleton pattern as a LoadBalancing object. Only a single instance (the singleton) of the class can be created because servers may dynamically come on- or off-line and every request must go throught the one object that has knowledge about the state of the (web) farm.

### .NET Optimized code in C#
The .NET optimized code demonstrates the same code as above but uses more modern, built-in .NET features.

Here is an elegant .NET specific solution. The Singleton pattern simply uses a private constructor and a static readonly instance variable that is lazily initialized. Thread safety is guaranteed by the compiler.
		  