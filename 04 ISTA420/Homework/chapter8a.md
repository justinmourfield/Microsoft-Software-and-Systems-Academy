### Author: Justin Mourfield
### Date : March 18, 2018
### Title: chapter08a

1. No but it allows you to control the association of values in those columns.

2. If you use INSERT SELECT you do have to use a subquery.   

3.The INSERT EXEC operand is the @ symbol.
 
4. You use the select into statement you add the keyword INTO and the table name before the from clause and it populates the rows you specify in the select clause into the table you specified in the INTO clause. 

5. The parameters of a bulk insert are the table you are inserting data into, the source file, and options.

6. The identity property does not ensure uniqueness. You can only do that by specifying primary key or unique constraints on that column. 

7. You create a sequence object with CREATE SEQUENCE the data type and the starting value and increment value. 

8. To use the SEQUENCE object, you invoke the function with NEXT VALUE FOR and the seqence name when a new value is created and you can use the returned value where ever you need to.

9. You can alter a sequence object by using the ALTER SEQUENCE phrase.

10. Delete is used to delete data from a table based on an optional filter predicate and TRUNCATE deletes all rows in the table without a filter.   

11. Drop table will not allow you to delete the table if a foreign key is pointing to it but delete will.  
