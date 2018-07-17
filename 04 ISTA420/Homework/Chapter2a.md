### Author: Justin Mourfield
### Date : March, 02, 2018
### Title: chapter02A
1. a primary key constraint is when you choose a candidate key as the primary means for identification
for a row/tuple it is equivalent to not nullable and a unique constraint

2. a nullibility constraint specifies whether an attribute supports NULLS. it prevents the absense
of a value in an area that should contain a value

3. Unique constraint enforces the uniqueness of rows, you cannot have two of the same values in a column.

4. foreign keys is a constraint that is defined on one or more attributes in the referencing table. 
it restricts values in the foreign key column to those that exist in the referenced columns. f
foreign keys point to another table. the values of the foreign key column must match the values of the column in the table that you are 
referencing. 

5. check constraints are used to define a predicate (a function that returns true or false) 
that a row must meet to be entered into the table

6. default constraint an expression that relates with a particular attribute and is used as the default value when an
explicit value is not specified for an attribute when you insert a row. 

7. domain integrity controls the validation of values of a column. you can use this to enforce the
type, format, and possible values of data stored in a column. (it ensures proper formatting)
  
8. in the WHERE clause you specify a predicate or logical expression to filter the rows returned 
by the FROM phase. the Having clause only returns values when the HAVING clause evaluates to true.
WHERE is a row filter and HAVING is a grouping filter. they both filter searches 

9. Parentheses are highest and = (assignment operator) is lowest.

10. null is not a value but rather a marker to designate that a value is missing


