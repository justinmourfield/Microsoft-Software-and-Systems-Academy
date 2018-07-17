### Author: Justin Mourfield
### Date: 07 March 2018
### File: Chapter3 SQL
1. You want to join tables to see data that correlates to each other but may not be directly listed in each individual table. It can also be used for combining data and sifting through data on different tables at one time if the tables are related. 
2. An inner join populates data that both tables have that match a predicate or comparison structure (matching data is IN the inner values that both tables hold. 
3. an Outer join populates data thats in both two tables and keeps data that did not have a corresponding match on the related table (left or right) and still presents it on the new combined table (matching data in both or data that does not have a match our outside of the matching criteria with the matching criteria being the predicate expression)
4. cross join combines every possible combination of the specified values from the two tables that are related that you are joining
5.
6. If there were a database with two separate tables such as location.table & teachingschedule.table that both listed all the different MSSA class types and the dates that they were conducted you could write a composite query to pull back training dates and the locations as; select location.classdate, location.classtype, teachingschedule.classdate, teachingschedule.classtype from dbo.location as t1 inner join dbo.teachingschedule as t2 on t1.classdate = t2.classdate and t1.classtype = t2.classtype 
7. the second query is correct both queries will populate customers who have not placed orders but the first one will keep all values wont add the rows with nulls to the populated results. 

Essentially left outer preserves the data that matches for both referencing tables and keeps data from the left side table that didnt match anything on the related table on the right. left.table = right.table  