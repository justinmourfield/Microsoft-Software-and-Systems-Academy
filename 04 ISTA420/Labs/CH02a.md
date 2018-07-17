-- .echo on
-- .headers on
--### Author: Justin Mourfield
--### Name: chapter2alab.sql
--### Date: 07 March 2018
select regiondescription from region;
select TerritoryDescription from territories;
select territorydescription, regionid from territories where regionid = 4;
territory.territorydescription
select t.territorydescription, t.regionid from territories t where regionid = 2
select customerid, contactname, phone, city from customers;  
select productid,productname, unitsinstock from products where unitsinstock = 0;
select productid,productname, unitsinstock from products where unitsinstock >0 order by unitsinstock desc limit 10
select productid,productname, unitprice from products order by unitprice desc limit 5 ;
select count (*) from products; select count (*) from customers;  select count (*) from suppliers;