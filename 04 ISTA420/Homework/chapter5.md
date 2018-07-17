1. A table expression is a query that represents a valid relational table but does not return a table itself. Essentially its a table that is created an exists only in the context of that query and isn't manifested in the database itself but can be interacted with as if it is.  

2.The derived tables are defined in the from clause of an outer query.

3. The sub query in a from clause will be ran first so it already exists by the time you make it to the outer clause so if the column alias is established in a sub-query then it can be referenced in an outer query.

4. The WITH key word. 

5. Yes they can be.
 
6. Yes separated by commas.
 
7. yes
 
8. A check option prevents modification through the view that conflict with how that view is filtered. The view is treated as a separate object and if you alter it with values that do not abide by the initial filtering parameters specified when the view was created, the inserted values will not show.   

9. The SCHEMABINDING key word combines the schema of the referenced objects and columns to the schema of the referencing object. 

10. A table valued function is a query that return a whole table result. That table may only exist in the context of just that query and then disappear or it may be a permanent object such as a view

11. APPLY operates on two input tables with the right table being a derived table or Table Value Function (TFV). The Cross APPLY  applies the right table to each row from the left and produces a result table with the combined values. 

12. There is two forms of the APPLY operator. APPLY Cross and OUTER APPLY. 