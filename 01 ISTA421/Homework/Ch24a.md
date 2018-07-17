### Author: Justin Mourfield
### Date : May, 03, 2018
### Title: chapter 24

1. An asyncronous method is a method that does not block the current thread on which it stsrts to run. when the method is invoked the contract between the operating environment and the method expects the method to return control to the calling environment quickly and to perform its work on a spearate thread. 

2. The tasks can produce the end result prior to the tasks being completed because they have deviated paths of execution that may not finish by the time the compilet executes the end result. 

3.In sets of continueWith method calls every subsequent method while passing the task object between themselves.

4.By passing a delegate the final continuation generates a System.Exception exception. I interpret the error message as it saying the that it is trying to access an interface it does not have control over to execute the task. 

5. It is messy and difficult to maintain.

6.The async modifier specifies that a method can have tasks run asyncronously from each other. the await operator specifies the points at which the asyncronous functionality should be performed. this means that the code following the keyword can be executed and the calling methhod is paused but a thread if freed for other use. once the awaited method is complete, control is transferred back to the calling method. it provides a linear format to certain aspects of the code when necessary. 

7.the awaitable object is a type that exposes methods for running code and waiting for it to complete. 

8. accessmodifier, async, Type, methodNamethe(); you name a task within the method body and run the task. the compiler determines what the return value of an awaited operation is.

9. You create a task within an async method, use a labmda expression to invoke the method and then using the await keyword in front of the name of the task is how you reference the "return value" of the task method. 

10.If you need a result returned from a task, then using the Task<TResult> generic class will provide you that venue. The result property of the Task<TResult>object is the same thing as the return value of a normal method. It holds the value of that specified object after the operation is complete. The await operator exracts the value from the task returned by the async method call. 

11.the await operator indicates the method should be run by a separate task and the calling code is suspended until that method call is complete. the wait method always blocks the current thread and does not allow it to be reused until the tsk completes. 