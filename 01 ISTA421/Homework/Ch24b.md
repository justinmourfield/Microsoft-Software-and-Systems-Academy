### Author: Justin Mourfield
### Date : May, 04, 2018
### Title: chapter 24b

1.Scenarios that involve data sets with large numbers of elements or if the criteria specified for matchting data involves complex computationally expensive operations. 

2.Extension methods further add functionality to previously created types without creating new derieved types, recompiling, or otherwise modifying the original type. the "asParallel" type futher extends the LINQ query class by allowing the wuery to partition data into smaller sects and operate multiple threads to search these sects and then compile the data at the end of the query into one set. 

3.You can cancel a PLINQ query by creating a cancellation token from a cancellationtokensource and use the withcancellation method of the parallelquery extension method. its an extension of an extension. you specify a parallel and cancellable method constraint in the from clause of the query.

4.It is important to syncronize access to a server because if two operations are running concurrently that change and read the data, they may not execute perfectly in parallel and the data may be overwritten by the time it is read. 

5.the lock statement ensures exclusive access to resources. the lock statement attempts to obtain a mutually exclusie lock over the specified object. and it blocks if this same object is currently locked by another thread. 

6.Mutex and semaphore are both syncronization primitives. mutex ensures that only a producer of information can run and prevent a consumer of that information from accessing the information being produced. or vice versa. bascially mutex is aa locking mechanism preventing more than one thing accessing a resource. semaphore is a signaling mechanism. semaphore restricts the number of keys that are used as a mutex to operations. threads can access a specified amount of keys which is specified by the semaphore. when a key is in use the semaphore is decremented and vice versa. 

7.Collections are not thread safe in the sense that multiple operations can access and manipulate the contained data at the same time. this can lead to data corruption the same way a linq query to delete data and a linq query to read data operating concurrently would result in an issue.  

8.collections are made thread safe by using the syncronization primitives to wrap code that adds, queries, and removes elements in a collection. this is not an effective procedure so the system.collection.concurrent namespace has collections designed for this task.

9. using thread safe collections increases comptational work because the compiler needs to assess whether the collection is being used by another operation prior to executing the new operation. 