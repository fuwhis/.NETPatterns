## C# Chain of Responsibility
The `Chain of Responsibility` design pattern avoids coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. This pattern chains the receiving objects and passes the request along the chain until an object handles it.

Frequency of use: ![measure](https://www.dofactory.com/img/patterns/use-medium-low.jpg) medium-low
## UML class diagram
A visualization of the classes and objects participating in this pattern.

![Class Diagram](https://www.dofactory.com/img/diagrams/net/chain.png)

## 	Participants
The classes and objects participating in this pattern include:

-  **Handler** (`Approver`)
	- defines an interface for handling the requests.
	- (optional) implements the successor link.
-  **ConcreteHandler** (`Director`, `VicePresident`, `President`)
	- handles requests it is responsible for
	- 
	- 
-  **UnsharedConcreteFlyweight** (not used)
	- not all Flyweight subclasses need to be shared. The Flyweight interface `enables` sharing, but it doesn't enforce it. It is common for UnsharedConcreteFlyweight objects to have ConcreteFlyweight objects as children at some level in the flyweight object structure (as the Row and Column classes have).
-  **FlyweightFactory** (`CharacterFactory`)
	- creates and manages flyweight objects.
	- ensures that flyweight are shared properly. When a client requests a flyweight, the FlyweightFactory objects assets an existing instance or creates one, if none exists.
-  **Client** (`FlyweightApp`)
	- maintains a reference to flyweight(s).
	- computes or stores the extrinsic state of flyweight(s).

## Structure of Console Code
### Structural code in C#
This structural code demonstrates the Flyweight pattern in which a relatively small number of objects is shared many times by different clients.

**Output**
```
------------------Structural Code--------------------
ConcreteFlyweight: 21
ConcreteFlyweight: 20
ConcreteFlyweight: 19
UnsharedConcreteFlyweight: 18
```
### Real-world code in C#
This real-world code demonstrates the Flyweight pattern in which a relatively small number of Character objects is shared many times by a document that has potentially many characters.

**Output**
```
-------------------Real-world Code------------------
A (pointsize 11)
A (pointsize 12)
Z (pointsize 13)
Z (pointsize 14)
B (pointsize 15)
B (pointsize 16)
Z (pointsize 17)
B (pointsize 18)```
### .NET Optimized code in C#
The .NET optimized code demonstrates the same real-world situation as above but uses modern, built-in .NET features, such as, generics, reflection, LINQ, lambda functions, etc. You can find an example on our Singleton pattern page.	  