### Author: Justin Mourfield
### Date : April 14, 2018
### Title: chapter17

1. A type parameter is a placeholder that specifies the type of objects on which they operate. The formal type of parameter being passed into the Generic Type class is determined at runtime. the T is often used as this placeholder until an actual type is assigned. A class is defined as generic
class CLASSNAME <T>{

2.A type parameter allows flexibility without having to create redundancy of code by the use of overloading. You use a generic as such:
GenericClass<type of object> NameofGenericObject = new GenericClass<type of object>();

3.A generic class can have multiple type parameters. 

4.A generic class takes type parameters and a generalized class takes multiple parameters that can be cast as other types. 

5.A constraint is a limitation on the type of applicable objects that can be used by a generic class. such as using the Where keyword in conjunction with a parameter limitation

6.A generic method accepts and returns a type parameter in a manner similar to how a class utilizes them. access modifier, static/non GENERIC RETURN TYPE method name<Generic Place Holder> (ref genericTypeArgument nameOfArg) i.e. private static void swap(ref TItem A, ref TItem B)

7. It means that you cannot assign an object to a reference of another object even if the object assigning its value to the new object is derived from the new object. 

8.Covariance allows you to force the compiler to allow a type reference of multiple objects as long as the two objects ae of the same type. You do this by using the out keyword, and as long as type A can be converted to type B or type A derives from type B.This only works if the return type of the method is the same.

9. Covariance only works with reference types because value types cannot form inheritance structures. 

10. Contravariance is similar to covariance but works in the opposite direction. It enabes you to use a generic interface to reference an object of type B through a reference of type A. 


