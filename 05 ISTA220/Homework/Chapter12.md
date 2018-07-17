### Author: Justin Mourfield
### Date : March 23, 2018
### Title: chapter12

1. Inheritance allows you to write one implementation of something and allow other classes to use that implementation without having to repeat the same lines of code in the derived classes. 
2. Derived class:base class (Whale:Mammal).
3. Classes derive from objects and structs inherit from value type.
4. The computer will attempt to make a silent call to the base classes constructor. 
5. Yes but only if the variable you are assigning does not conflict by being previously assigned to another derived class.
6. only if they are of the same derived class. 
7. yes you can assign a name class to a derived class but it overwrites the polymorphism aspects of the derived class.  
8. If the method of a base class has the same name as a method in a derived class but different implementations.   
9. a virtual method is a method that has implementation in a class but a derived class is able to provide new implementation.    
10. the override key word is used to provide new implementation of a virtual method in a base class. 
11. you create a static method in a static class to which the method applies and specify the type of data to the method applies to as the argument to that method along with the THIS keyword such as the following: 
 public static int Negate(this int i)
 {
 return -i;
 }
12. To provide new functionality to a previously implemented static class. 