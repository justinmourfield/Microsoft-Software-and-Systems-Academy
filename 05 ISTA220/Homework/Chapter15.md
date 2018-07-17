### Author: Justin Mourfield
### Date : April 07, 2018
### Title: chapter15

1. A field is a piece of data are ordinary variables and properties are an intermediary abstraction used to read or write their values. 

2.A property uses a method to get and set its data but a property itself is not an action that can be used like a method.

3. encapsulation of data is the protective measures that are emplaced to prevent a program, programmer, or user from overwriting information that could lead to errors. it also prevents the program from having to worry about how the internal workings of a class work.

4. Depending on the naming conventions that you use for your program, the use of only an upper and lower case letter as a means for differeniation can easily and quickly become an issue and once it is an issue it more than likely will be easy to overlook. The difference of case in just the first letter is easily overlooked and in my opinion should not be the first option for differenciation. 

5. a read only property that is the health bar of a character in a video game. a write only property that is the damage output of a character in a video game that can recieve damage boosters. 

6.Getters and setters being private may be used if the data that is being written to that property is obtained by an action external to the class in which the property is contained. However this should be limited because it violates the idea of encapsulation of date

7. 
-You can only change one of the accessors to a different accessibility.
- the modifier must not specify the accessibility to be less restrictive than that of the property. such as having a private property but a public accessor. it should be a public property and a public accessor and a second public accessor or one private accessor.  
-you can assign a value through a property only after the struct or class that contains it has been initialized. 
-you cant use a property as a REF or OUT argument because they are essentially value types. 
-a property can contain at most one get accessor and one set accessor and cannot contain other methods, fields, or properties.
-the accessors cannot take any parameters. the data being assigned is passed to the set accessor automatically by using the value variable.
-You cant declare properties by using CONST 

8.An object initializer is when you create multiple instances of the same class and specify their values using properties instead of an explicitly named constructor. the default constructor calls the set accessor for each named property to initialize it with the specified value. Class objectName = new class {properties} 