### Author: Justin Mourfield
### Date : March, 02, 2018
### Title: chapter02b
1. List the order of execution of a SQL query. -- from, where, group by, having, select, order by
2. What does the from clause do? specifies the table to access to pull data from
3. What does the where clause do? picks out the rows you want info from and is a preposition keyword that is followed by constraints or search criteria
 that you want evaluated as part of the query
4. What does the group by clause do? -- used with the group functions to retrieve data grouped according to rows   
 (asce, desc, by city etc.) 
5. What does the having clause do? is used to filter data based on group functions. "group by" clauses can be used with having but with where
6. What does the select clause do? used to query data from columns 
7. What does the distinct keyword do? eliminates redundant results and only populates unique values 
8. What does the order by clause do? used in a select statement to specify how the results should be sorted and organized 
9. What does the limit clause do? places a constraint on the amount of results populated by a query
10. What does the top clause do? used in a select statement to return the highest numbers or percent row 
11. What do the offset . . . fetch . . . clauses do? limits the results that are populated to one window's worth of space. 


Where filters rows and having filters groups and select selects columns 
in takes an argument in the form of the list i.e. select country from customers where country in ('USA', 'Canada', 'Mexico');
Not - negates the following values or i.e. select  customerid, companyname, country from customers where country not in ('USA', 'Canada', 'Mexico');