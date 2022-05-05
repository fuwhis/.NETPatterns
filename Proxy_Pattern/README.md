## C# Proxy
The `Proxy` design pattern provides a surrogate or placeholder for another object to control access to it.

Frequency of use: ![measure](https://www.dofactory.com/img/patterns/use-medium-high.jpg) medium-high
## UML class diagram
A visualization of the classes and objects participating in this pattern.

![Class Diagram](https://www.dofactory.com/img/diagrams/net/proxy.png)

## 	Participants
The classes and objects participating in this pattern include:

-  **Proxy** (`MathProxy`)
	- maintains a reference that lets the proxy access the real subject. Proxy may refer to a Subject if the RealSubject and Subject interfaces are the same.
	- provides an interface identical to Subject's so that a proxy can be substituted for for the real subject.
	- controls access to the real subject and may be responsible for creating and deleting it.
	- other responsibilites depend on the kind of proxy:
		- *remote proxies* are responsible for encoding a request and its arguments and for sending the encoded request to the real subject in a different address space.
		- *virtual proxies* may cache additional information about the real subject so that they can postpone accessing it. 
		For example, the ImageProxy from the Motivation caches the real images's extent.
		- *protection proxies* check that the caller has the access permissions required to perform a request.
-  **Subject** (`IMath`)
	- defines the common interface for RealSubject and Proxy so that a Proxy can be used anywhere a RealSubject is expected. 
-  **RealSubject** (`Math`)
	- defines the real object that the proxy represents.

## Structure of Console Code
### Structural code in C#
This structural code demonstrates the Proxy pattern which provides a representative object (proxy) that controls access to another similar object.

**Output**
```
------------------Structural Code--------------------
Called RealSubject.Request()
```
### Real-world code in C#
This real-world code demonstrates the Proxy pattern for a Math object represented by a MathProxy object.

**Output**
```
-------------------Real-world Code------------------
4 + 2 = 6
4 - 2 = 2
4 * 2 = 8
4 / 2 = 2
```
### .NET Optimized code in C#
The .NET optimized code demonstrates the same real-world situation as above but uses modern, built-in .NET features, such as, generics, reflection, LINQ, lambda functions, etc. You can find an example on our Singleton pattern page.	  