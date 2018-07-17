.echo on
.headers on
--Name: Chapter06bLab.sql
--Date: 21 March, 2018
--Author: Justin Mourfield

SELECT TOP (1000) [custid], [empid], [orderdate]
 FROM [TSQLV4].[Sales].[Orders]
 where orderdate like '2016-01-%'
 except
 SELECT TOP (1000) [custid], [empid], [orderdate]
 FROM [TSQLV4].[Sales].[Orders]
 where orderdate like '2016-02-%';

 SELECT TOP (1000) [custid], [empid] 
 FROM [TSQLV4].[Sales].[Orders]
 where orderdate like '2016-01-%'
 intersect
 SELECT TOP (1000) [custid], [empid]
 FROM [TSQLV4].[Sales].[Orders]
 where orderdate like '2016-02-%';

 SELECT TOP (1000) [custid], [empid] 
 FROM [TSQLV4].[Sales].[Orders]
 where orderdate like '2016-01-%'
 intersect
 SELECT TOP (1000) [custid], [empid] 
 FROM [TSQLV4].[Sales].[Orders]
 where orderdate like '2016-02-%'
 except
  SELECT TOP (1000) [custid], [empid]
 FROM [TSQLV4].[Sales].[Orders]
 where orderdate like '2015-%';