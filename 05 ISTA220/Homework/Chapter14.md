### Author: Justin Mourfield
### Date : March 31, 2018
### Title: chapter14

1. A managed resource is an item that we control the existence of i.e. all reference type variables. Unmanaged resources are items we do not detemine when their memory is reallocated, i.e. value types. 

2. memory for a reference variable is created initially when the new keyword is processed but it is not fully allocated until the object is instantiated. memory is deallocated whenever the variable is out of scope although this may not happen immediately. 

3. A destructor is a block of code that performs any actions necessary for a managed or unmanaged resources allocated memory to be cleared.  

4. a deconstructor uses the tilde or (~) symbol followed by the name of the class.

5.file streams, network connections, database connections. if you do not reallocate memory after using these items you risk having an exception for system out of memory.

6.Utilizing a finally block that incorporates a disposal method so that if the initial disposal method is skipped due to an exception, the finally block will still execute a disposal method and terminate any handles or previous memory allocations.

7.it specifies the time period in which the resource will be utilized and for how long the resource exists in the current context. 

8. It could affect the logical integrity of the application because it is trying to destroy an object that is already destroyed.

9. Threads are concurrent tasks or essentially multitasking. if there is too many resources being pulled simultaneosly without appropriate release of those resources or proper allocation per thread, the system will throw an exception for out of memory.

10.You do not want to force the garbage collector because it may call it but the memory will not be freed up at the time you call it necessarily. it could also have an impact on when the objects are disposed of and still result in out of memory exception. 