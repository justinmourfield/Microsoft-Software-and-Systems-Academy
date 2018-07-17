### Author: Justin Mourfield
### Date : April, 07, 2018
### Title: Chapter4


1. Using automatic properties circumvents you having to explicity define getter and setter methods. this keep you from having to declare the property as a field and then write two methods for each field to make them properties. 

2.Using the object initializer it prevents you from having to declare the new instance of the object, individually assign values to properties, and then call a method that uses the object as three separate steps. it combines them into the following syntax: Class nameOfObject = new Class{property =value(comma separated properies)}; then the method if applicable. 

3.Extension methods are created to provide increased functionality to classes that the .Net framework internally owns such as Console class. 

4.The THIS keyword in front of the  first parameter marks the method as an extension method.

5. you use the yield keyword in the return statement and when you declare the method, you specify the collection of objects to filter, and the filter option which matches the objects property.

6.You specify input parameters on the left hand side, the lamba expression operator "=>" and the expression or statement block on the right side.

7.var are implicity but statically typed variables. dynamic are dynamically typed which means they are resolved at run time vs var are resolved at compile time and decided by the compiler. var can be used to decide the data type of a variable and that data type cannot change, but the data type of dynamic variables can change without having to declare a new variable name. 

8.The dot notation seems to replace the paranthese specified commands in SQL.

9.AWAIT puts a pause on the specified operation until certain conditions are met. 

10. you use AWAIT to specify that you are waiting for the result of whatever ASYNC operation is going on.
