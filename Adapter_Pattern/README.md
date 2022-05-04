## C# Adapter
The `Adapter` design pattern converts the interface of a class into another interface clients expect. This design pattern lets classes work together that couldn't otherwise because of incompatible interfaces.

Frequency of use:  ![measure](https://www.dofactory.com/img/patterns/use-medium-high.jpg)  medium-high
## UML class diagram
A visualization of the classes and objects participating in this pattern.

![Class Diagram](https://www.dofactory.com/img/diagrams/net/adapter.png)

## 	Participants
The classes and objects participating in this pattern include:

- **Target** (`ChemicalCompound`)
	- defines the domain-specific interface that Client uses.
- **Adapter** (`Compound`)
	- adapts the interface Adaptee to the Target interface.
- **Adaptee** (`ChemicalDatabank`)
	- defines an existing interface that needs adapting.
- **Client** (`AdapterApp`)
	- collaborates with objects conforming to the Target interface.

## Structure of Console Code
### Structural code in C#
This structural code demonstrates the Adapter pattern which maps the interface of one class onto another so that they can work together. These incompatible classes may come from different libraries or frameworks.

**Output**
```
Called SpecificRequest()
```
### Real-world code in C#
This real-world code demonstrates the use of a legacy chemical databank. Chemical compound objects access the databank through an Adapter interface.

**Output**
```
Compound: Unknown ------

Compound: Water ------
 Formula: H20
 Weight : 18.015
 Melting Pt: 0
 Boiling Pt: 100

Compound: Benzene ------
 Formula: C6H6
 Weight : 78.1134
 Melting Pt: 5.5
 Boiling Pt: 80.1

Compound: Alcohol ------
 Formula: C2H6O2
 Weight : 46.0688
 Melting Pt: -114.1
 Boiling Pt: 78.3
```
### .NET Optimized code in C#
The .NET optimized code demonstrates the same code as above but uses more modern, built-in .NET features.
*Be Continued...*
		  
