### Author: Justin Mourfield
### Date : March, 02, 2018
### Title: chapter01
																				T-SQL Chapter 1 
1. A database is a system of related information that is managed and curated based on the 
premise of using set theory and predicate logic in order to organize information.

2. informally, its data for the human resources dept. 

3. Entity integrity prevents more than one occurrence of a tuple (row) in a relation (table/set)

4. referential integrity restricts the values in the referencing relation to the values that appear
in the referenced relations candidate key attributes.  
----------------------------a doctor is a primary key and the patients are the foreign keys.--------------------------------------
----------------------------atomic values are their form i.e. they cannot be divided into smaller sections------------------------ 

5. a set/table

6. no, because the facCreds contains multiple values that are all dependent on the primary key
the facCred should have multiple columns, one for each degree a person has. 

7. no because there is redundancy of primary keys which could result in the incorrect information being
returned from a query. 

8. no because there are multiple states that can have the same city. the table should be split by using the name and zip as one table and 
the zip and address being on the second. the zip is a foreign key on the first table and the primary key of the address table.

9. An OLTP is an on-line transactional processing database and its primary focus is data entry 
and not reporting

10. the most simplistic data warehouse design optimized for data analysis.