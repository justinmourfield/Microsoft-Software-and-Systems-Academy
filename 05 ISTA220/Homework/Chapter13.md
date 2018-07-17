### Author: Justin Mourfield
### Date : March 31, 2018
### Title: chapter13

1. A collection of items (objects, classes, structs) that focuses on what they are and not so much on how they work.

2. You use an "interface" keyword instead of class and name all methods without an access modifier or implementation. Each method must be named for each type of data in the interface.

3. An interface cannot contain data. 

4. datatype nameofmethod(parameter);

5. You can make an object and then have it refer to an instance of an interface but only if the interface is higher up the inheritance chain. Interfaces cannot contain implementation.  

6.

7.an object can inherit multiple interfaces because a class can have an unlimited amount of interfaces. 

8. Explicitly implementing an interface means you designate the interface in which you are referring to and the method contained within the interface. 

9.The limitations of an interface are:
-You cant define fields, properties, or other data assignment. 
-you can define constructors
-you cant define deconstructors
-you cant specify access modifiers 
-you cant nest any types inside of an interface (enuerations, structs, classes, or other interfaces)
-an interface is not allowed o inherit from a struct or class but can inherit from other interfaces.

10. An abstract class can contain data such as fields 

11. An abstract method is a named method that is inherently public and does not contain a method body. its meant to be overridden in derived classes to provide their own implementation.

12.A sealed class is a modifier to a class that prevents that class from being used as a base class. 

13. A sealed method means that a derived class cannot override the implementation of this method. 