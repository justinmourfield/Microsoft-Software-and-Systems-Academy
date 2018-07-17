-- .echo on
-- .headers on
--### Author: Justin Mourfield
--### Name: chapter2blabs.sql
--### Date: 07 March 2018
1. select companyname from customers where country like 'usa';
select companyname from customers where country like 'mexico';
select companyname from customers where country like 'canada';
2. select orderid from orders where orderdate between '1998-04-01' and '1998-04-30';
3. Aniseed syrup, Genen Shouyu, northwood's cranberry sauce, Sirop d'érable, 
Louisiana Fiery Hot Pepper Sauce, 
4. select * from products where categoryid = 7;.
5. 1,3,4
6. We have an issue with product 19. I need to know the total amount and the net amount of all orders
for product 19 where the customer took a discount.  
select count (orderid) from order_details where productid = 19 and discount >= 0;
select orderid from order_details where productid = 19 and discount >= 0;
select sum (quantity) from order_details where productid = 19 and discount >= 0;
7. select title, firstname, lastname from employees;
8.  select contactname from customers union select firstname from employees.
9. select contactname from customers order by contactname desc;
10. How many days old are you today?