## C# Builder
The `Builder` design pattern separates the construction of a complex object from its representation so that the same construction process can create different representations.

Frequency of use:  ![measure](https://www.dofactory.com/img/patterns/use-medium-low.jpg)  medium-low
## UML class diagram
A visualization of the classes and objects participating in this pattern.

![Class Diagram](https://www.dofactory.com/img/diagrams/net/builder.png)

## 	Participants
The classes and objects participating in this pattern include:

- **Builder** (`VehicleBuilder`)
	- specifies an abstract interface for creating parts of a Product object.
- **ConcreteBuilder** (`MotorCycleBuilder`, `CarBuilder`, `ScooterBuilder`)
	- constructs and assembles parts of the product by implementing the Builder interface.
	- defines and keeps track of the representation it creates.
	- provides an interface for retrieving the product.
- **Director** (`Shop`)
	- constructs an object using the Builder interface.
- **Product** (`Vehicle`)
	- represents the complex object under construction. ConcreteBuilder builds the product's internal representation.
	- includes classes that define the constituent parts, including interfaces fot assembling the parts into the final result.

## Structure of Console Code
### Structural code in C#
This structural code demonstrates the Abstract Factory pattern creating parallel hierarchies of objects. Object creation has been abstracted and there is no need for hard-coded class names in the client code.

**Output**
```
Product Parts ------
PartA
PartB

Product Parts ------
PartX
PartY
```
### Real-world code in C#
This real-world code demonstrates the creation of different animal worlds for a computer game using different factories. Although the animals created by the Continent factories are different, the interactions among the animals remain the same.

**Output**
```
---------------------------
Vehicle Type: Scooter
 Frame  : Scooter Frame
 Engine : none
 #Wheels: 2
 #Doors : 0

---------------------------
Vehicle Type: Car
 Frame  : Car Frame
 Engine : 2500 cc
 #Wheels: 4
 #Doors : 4

---------------------------
Vehicle Type: MotorCycle
 Frame  : MotorCycle Frame
 Engine : 500 cc
 #Wheels: 2
 #Doors : 0

```
### .NET Optimized code in C#
The .NET optimized code demonstrates the same code as above but uses more modern, built-in .NET features.
*Be Continued...*
		  