# Design Pattern — Builder

What is a design pattern:
A design pattern is a general, reusable solution to a common problem that occurs in software development. These patterns are abstract descriptions or models that can be applied to different scenarios, providing a framework or approach to solving recurring problems in system design and architecture with an object-oriented programming paradigm.

## HamburgerBuilder (Abstract Class)
This is an abstract class that defines a series of “common” methods that child classes must implement to build a hamburger with different ingredients.

## AlainProstHamburgerBuilder (Concrete Class)
This class inherits from HamburgerBuilder and implements the methods defined in the abstract class to build a specific hamburger with defined characteristics.

## AyrtonSennaHamburgerBuilder (Concrete Class)

Similar to the previous class, it inherits from HamburgerBuilder and implements its own methods to build a hamburger in the Ayrton Senna style.

## NelsonPiquetHamburgerBuilder (Concrete Class)
Another concrete class that inherits from HamburgerBuilder, customizing the construction of a hamburger according to the preferences attributed to Nelson Piquet.

## RubensBarricheloHamburgerBuilder (Concrete Class)
Similar to the others, but with specific construction characteristics for Rubens Barrichelo's hamburger style.

## SchumarHamburgerBuilder (Concrete Class)
Implements the construction of a hamburger in the “Schumar” style with specific ingredients and construction method.

## Hamburger (Class)
This is the class that represents the final object that will be built by the “builder” classes.

## Salad (Class)
Represents the salad ingredients that can be added to the burger.

## HamburgerDirector (Class)
This class is responsible for managing the burger construction process using the different “builders”.

The HamburgerDirector class coordinates the process of building different types of burgers, using different concrete HamburgerBuilder classes. Each specialized builder (such as AlainProstHamburgerBuilder or AyrtonSennaHamburgerBuilder) implements the process of building a burger with its own variations of ingredients. The end result is a customized Hamburger object.

## Conclusion

The Builder pattern is especially useful in scenarios where creating an object involves many variables or complex steps. It provides a structured and modular way of building objects, improving code clarity and separation of concerns. By encapsulating the construction process, it facilitates maintenance and evolution of the software, allowing the creation of products in a consistent and flexible way, without sacrificing simplicity.
