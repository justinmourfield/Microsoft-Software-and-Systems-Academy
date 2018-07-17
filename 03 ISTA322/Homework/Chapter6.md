### Author: Justin Mourfield
### Date : April 14, 2018
### Title: Chapter6


1. The idea of dependancy injection is to decouple the components in an MVC application, with a combination of interfaces and DI containers that creates instances of objects by creating implementations of the interfaces the depend on and injecting tem into the constructor. 

2. interfaces take out the dependancy of operations from one compenent to the next by allowing for methods to be exposed without having to rely on another object to implement those methods before another compentent can utilize them. 

3.1st is to prepare Ninject for use by creating an instance of a Ninject Kernel which is the object responsible for resolving dependancy and creating new objects. 2nd is to configure the Ninject kernel so that it understands which implementation objects you want to use for each interface. third is to use nonject to create an object which you do through the kernel Get method.

4.by creating a custom resolver, you can ensure that the MVC framework uses Ninject whenever it creates an object including instance of controllers. 

5.conditional binding is the act of tieing interfaces to the object that uses them and providing flexibility to those dependancies allowing for variation of what should be used or instantiated. this works by examining the parameters and finding the best fit for those parameters.  

6.scope allows you to perform garbage collection.

7.Test driven development means once you specify the requirements of the application you write tests to ensure that what is implemented has the correct functionality to satisfy those requirements. 

8.you use the assert methods after adding the using statement of the namespace that contains the assert class. 

9.Mock objects simulate the functionality of real objects but in a controlled way to enhance testing efforts. 

10. it can be complex and brittle without mock objects because you are relying on dependancies of objects that need to be created but the object itself may act in an unexpected way. the implementation is also unflexible. 
