### Author: Justin Mourfield
### Date : March 27, 2018
### Title: chapter08b

1. UPDATE db SET Rate = new rate where state like "state name".

2.select salesamount salesid, 3.5, as newrate , (salesamount * newrate) 

3.Allows a user to update data in the table and assign values to variables at the same time. it uses a variable to store the amount of the update which is then applied to the values of the row by using a select statement to specify the variable that has the value to be updated with. it works as a "transaction" and alleviates having to run separate update functions. 

4. it combines multiple statements (insert, update and delete). ETL is extract transform and load. It is a technique for loading data into databases and shaping it to meet query reqs. 

5. Merge semantics are rooted in join semantics. you specify the target table of the merge, the source table in the using clause, the merge is specified by a predicate in the On clause, and boolean logic is applied to identify if a value matches. if it matches the query specifies actions as well as if it does not match. 

6.Insert into "table" select(columns) from (Subquery which includes update keyword and values to be used as update /output = specifying the desired outcome of the update where - specifying on what conditions will the update be applied) where - for outer query to specifcy conditions of what is to be selected in the select clause.  
7. 
8.
9.
10. nested dml allows you to directly insert into the final target table only the rows you need from the full set of modified rows. 