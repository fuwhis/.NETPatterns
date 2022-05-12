## C# Chain of Responsibility
The `Chain of Responsibility` design pattern avoids coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. This pattern chains the receiving objects and passes the request along the chain until an object handles it.

Frequency of use: ![measure](https://www.dofactory.com/img/patterns/use-medium-low.jpg) medium-low
## UML class diagram
A visualization of the classes and objects participating in this pattern.

![Class Diagram](https://www.dofactory.com/img/diagrams/net/chain.png)

## 	Participants
The classes and objects participating in this pattern include:

-  **Handler** (`Approver`)
	- defines an interface for handling the requests
	- (optional) implements the successor link
-  **ConcreteHandler** (`Director`, `VicePresident`, `President`)
	- handles requests it is responsible for
	- can access it successor
	- if the ConcreteHandler can handle the request, it does so; otherwise it forwards the request to its successor
-  **Client** (`ChainApp`)
	- initiates the request to a ConcreteHandler object on the chain

## Structure of Console Code
### Structural code in C#
This structural code demonstrates the Chain of Responsibility pattern in which several linked objects (the Chain) are offered the opportunity to respond to a request or hand it off to the object next in line.

**Output**
```
------------------Structural Code--------------------
ConcreteHandler1 handled request 2
ConcreteHandler1 handled request 5
ConcreteHandler2 handled request 14
ConcreteHandler3 handled request 22
ConcreteHandler2 handled request 18
ConcreteHandler1 handled request 3
ConcreteHandler3 handled request 27
ConcreteHandler3 handled request 20
```
### Real-world code in C#
This real-world code demonstrates the Chain of Responsibility pattern in which several linked managers and executives can respond to a purchase request or hand it off to a superior. Each position has can have its own set of rules which orders they can approve.

**Output**
```
-------------------Real-world Code------------------
Director Larry approved request# 2034
President Tammy approved request# 2035
Request# 2036 requires an executive meeting!
```
### .NET Optimized code in C#
The .NET optimized code demonstrates the same real-world situation as above but uses modern, built-in .NET features, such as, generics, reflection, LINQ, lambda functions, etc. You can find an example on our Singleton pattern page.	  