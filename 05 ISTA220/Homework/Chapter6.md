### Author: Justin Mourfield
### Date : March, 02, 2018
### Title: chapter06

1. an exception is an error that happened during runtime of the code. generally an unexpected error.
2.nothing technically, however a try block is used to encapsulate a block of code in preparation for exceptions to be thrown. therefore if the code executes without problems, the try block does nothing other than execute the code it encapsulates
3.a catch block is used to incorporate actions to be taken for named exceptions. if an unhandled or (unaccounted for) exception takes place, a catch block may contain a way of generically handling it such catch(exception){ex.message(there was an unhandled exception)}
4.if an exception block fails to handle an error the program is terminated 
5.exception is the parent class for all exceptions and contains a multitude of exceptions that commonly happen. its the trunk of the tree while each class of exceptions are the branches.
6.you can determine the type of error by stepping through the execution of the code and seeing where the error took place and either explicitly realizing the error or by calculated guesswork. you handle these exceptions by adding catch blocks to a try statement
7.integer checking allows you to evaluate if there is overflow past the points of precision or the memory space allocated for an integer variable
8. the finally block inserts a statement to be executed regardless of if an exception takes place. essentially its a failsafe
