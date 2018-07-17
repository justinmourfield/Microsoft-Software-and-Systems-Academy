### Author: Justin Mourfield
### Date : March, 02, 2018
### Title: chapter02c
1.  data type specifies the form of data being input and designates the amount of memory it will require, and what operations can be performed on or with those data types 
2. What is a collation? Name four elements of a collation. refers to a set of rules that dictate how information is sorted and stored. 
Collation is a property of character data. the four elemnts are language support, sort order, case sensitivity, and accent sensitivity plus more. 
3.  |RTRIM of LTRIM depending on where the white space is 
4. Suppose you wanted to make a list of every college and university that was called an Institute from
the college table. Write the query. Select * from college where name like (%institute%);
5. How would you nd out the index of the rst space in a string? For example, the index of the rst
space in \Barack Hussein Obama" would be 7. select charindex (' ' ,'Barack Hussein Obama');
6. How would you select just the rst name in a list of the presidents. First names can be an arbitrary
length, from \Cal" to \Benjamin." substring (president's name, 1, Charindex(' ', presidents name))
7. Payments are due exactly 30 days from the date of the last function. Write a select query that calculates
the date of the next payment. Pretend we want to update a column in a database that contains the
date of the next payment. We will do this when we write UPDATE queries. Select DATEADD (day, 30, 20180301)
8. Suppose your son or daughter wants to run a query every day that tells them the number of days until
their 16th birthday. Write a select query that does this. SELECT  DATEDIFF (day, 20180301, 20180325) 
9. What function returns the current date? This is very useful in a table that maintains a log of events,
such as user logins. GETDATE 