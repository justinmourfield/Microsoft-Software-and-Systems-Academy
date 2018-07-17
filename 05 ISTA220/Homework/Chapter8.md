### Author: Justin Mourfield
### Date : March 12, 2018
### Title: chapter08

1. the difference between deep copy and shallow copy is a deep copy will clone reference and value types or data as opposed to a shallow copy which only clones reference type data. 

2. The value of a reference is the value you assign unless it is referencing another variable of reference type in which case it will contain the value of that referenced variable.

3. int value=0

4. ref int referencedVariableName

5.You cannot assign null to a value type because null itself is a reference type. 

6.You cannot assign a nullable value type to a non-nullable variable. They are two different things. a nullable value type is saying that this type of data may or may not exist in the variable that is being initialized. A null variable says that there is no value contained in this variable.

7. The stack is a first in last out section of memory where a heap is more dynamic and can be accessed recalled without it being executed in certain order. 

8.Boxing will assign the value of a value type variable to a reference type variable instead of directly linking the two directly to the same memory location. Unboxing allows you to determine the value held in a variable that a reference type is linked to. essentially boxing allows you to declare a value type variable and assign a reference type to hold the same value whereas unboxing allows a value type variable to be assigned the value of a reference type.  

9. The REF keyword references the actual argument instead of creating a copy of it to be manipulated. essentially ref is used to point to the same place in memory and allow it to be manipulated. 

10.The out keyword creates an alias for the parameter so a method can initialize a value. if out is used a method must assign a value to that variable before it finishes or returns 

11. The function of cast is to check to ensure that you are able to safely convert an item of one type to another.