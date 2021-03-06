## C# Composite
The `Composite` design pattern composes objects into tree structures to represent part-whole hierarchies. This pattern lets clients treat individual objects and compositions of objects uniformly.

Frequency of use:  ![measure](https://www.dofactory.com/img/patterns/use-medium-high.jpg)  medium-high
## UML class diagram
A visualization of the classes and objects participating in this pattern.

![Class Diagram](https://www.dofactory.com/img/diagrams/net/composite.png)

## 	Participants
The classes and objects participating in this pattern include:

- **Component** (`DrawingElement`)
	- declares the interface for objects in the composition.
	- implements default behavior for the interface common to all classes, as appropriate.
	- declares an interface for accessing and managing its child components.
	- (optional) defines an interface for accessing a component's parent in the recursive structure, and implements it if that's appropriate.
- **Leaf** (`PrimitiveElement`)
	- represents leaf objects in the composition. A leaf has no children.
	- defines behavior for primitive objects in the composition.
- **Composite** (`CompositeElement`)
	- defines behavior for components having children.
	- stores child components. 
	- implements child-related operations in the Component interface.
- **Client** (`CompositeApp`)
	- manipulates object in the composition through the Component interface.

## Structure of Console Code
### Structural code in C#
This structural code demonstrates the Composite pattern which allows the creation of a tree structure in which individual nodes are accessed uniformly whether they are leaf nodes or branch (composite) nodes.

**Output**
```
-root
---Leaf A
---Leaf B
---Composite X
-----Leaf XA
-----Leaf XB
---Leaf C
```
### Real-world code in C#
This real-world code demonstrates the Composite pattern used in building a graphical tree structure made up of primitive nodes (lines, circles, etc) and composite nodes (groups of drawing elements that make up more complex elements).

**Output**
```
-+ Picture
--- Red Line
--- Blue Circle
--- Green Box
---+ Two Circles
----- Black Circle
----- White Circle
```
### .NET Optimized code in C#
The .NET optimized code demonstrates the same code as above but uses more modern, built-in .NET features.
*Be Continued...*
		  
