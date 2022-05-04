## C# Factory Method
The `Factory Method` design pattern defines an interface for creating an object, but let subclasses decide which class to instantiate. This pattern lets a class defer instantiation to subclasses.

Frequency of use:  ![measure](https://www.dofactory.com/img/patterns/use-high.jpg)  high
## UML class diagram
A visualization of the classes and objects participating in this pattern.

![Class Diagram](https://www.dofactory.com/img/diagrams/net/factory.png)

## 	Participants
The classes and objects participating in this pattern include:

- **Product** (`Page`)
	- defines the interface of objects the factory method creates.
- **ConcreteProduct** (`SkillsPage`, `EducationPage`, `ExperiencePage`)
	- implements the Product interface.
- **Creator** (`Document`)
	- declares the factory method, which returns an object of type Product. Creator may also define a default implementation of the factory method that returns a default ConcreteProduct object.
	- may call the factory method to create a Product object.
- **ConcreteCreator** (`Report`, `Resume`)
	- overrides the factory method to return an instance of a ConcreteProduct.

## Structure of Console Code
### Structural code in C#
This structural code demonstrates the Factory method offering great flexibility in creating different objects. The Abstract class may provide a default object, but each subclass can instantiate an extended version of the object.

**Output**
```
Created ConcreteProductA
Created ConcreteProductB
```
### Real-world code in C#
This real-world code demonstrates the Factory method offering flexibility in creating different documents. The derived Document classes Report and Resume instantiate extended versions of the Document class. Here, the Factory Method is called in the constructor of the Document base class.

**Output**
```
Resume -------
 SkillsPage
 EducationPage
 ExperiencePage

Report -------
 IntroductionPage
 ResultsPage
 ConclusionPage
 SummaryPage
 BibliographyPage
```
### .NET Optimized code in C#
The .NET optimized code demonstrates the same code as above but uses more modern, built-in .NET features.
*Be Continued...*
		  
