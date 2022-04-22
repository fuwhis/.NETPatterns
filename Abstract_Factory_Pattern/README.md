## C# Abstract Factory
The `Abstract Factory` design pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.

Frequency of use:  ![measure](https://www.dofactory.com/img/patterns/use-high.jpg)  high
## UML class diagram
A visualization of the classes and objects participating in this pattern.

![Class Diagram](https://www.dofactory.com/img/diagrams/net/abstract.png)

## 	Participants
The classes and objects participating in this pattern include:

- **AbstractFactory** (`ContinentFactory`)
	- declares an interface for operations that create abstract products
- **ConcreteFactory** (`AfricaFactory`, `AmericaFactory`)
	- implements the operations to create concrete product objects
- **AbstractProduct** (`Herbivore`, `Carnivore`)
	- declares an interface for a type of product object
- **Product** (`Wildebeest`, `Lion`, `Bison`, `Wolf`)
	- defines a product object to be created by the corresponding concrete factory
	- implements the AbstractProduct interface
- **Client** (`AnimalWorld`)
	- uses interfaces declared by AbstractFactory and AbstractProduct classes

## Structure of Console Code
### Structural code in C#
This structural code demonstrates the Abstract Factory pattern creating parallel hierarchies of objects. Object creation has been abstracted and there is no need for hard-coded class names in the client code.

### Real-world code in C#
This real-world code demonstrates the creation of different animal worlds for a computer game using different factories. Although the animals created by the Continent factories are different, the interactions among the animals remain the same.
![class-diagram](https://user-images.githubusercontent.com/29690027/164718285-7f921d47-ecc4-42ed-a6d0-141ee0a2618b.jpg)

### .NET Optimized code in C#
The .NET optimized code demonstrates the same code as above but uses more modern, built-in .NET features.
*Be Continued...*
		  
