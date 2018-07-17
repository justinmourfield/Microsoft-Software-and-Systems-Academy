### Author: Justin Mourfield
### Date : May 26, 2018
### Title: chapter11

1. Variables are used to temporarily store data for later use in the same batch in which they were declared. you use them by (Declare @i as int =10); i is the name of the variable. 

2.A batch is one or more T-SQL statements sent by a client application to SQL server for execution as a single unit. a transaction is an atomic unit of work. a batch can contain multiple transactions and a transacation can be submitted in parts as multiple batches. 

3. the scope of a variable is local to the batch that it is initialized within.

4.DELCARE @bd as datetime ; select date from dates where date like 'bd>currentdate'

5.not technically but it does have a while loop that can then be constructed to be a for loop.

6.a cursor in a nonrelationsal result with order guaranteed amongst rows

7.you can create a local temporary table by prefixing the name with a pound sign and the name. a global temporary table is prefixed with 2 pound signs.

8.A stored procedure is an alternative tool to the EXEC command for executing dynamic SQL code. a user defined function is to encapsulate logic that calculates something and returns a result. a trigger by definition is a stored procedure but its one that cannot be executed explicitly and is instead tied to an event. 

9.