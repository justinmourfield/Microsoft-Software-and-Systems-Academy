### Author: Justin Mourfield
### Date : June 19, 2018
### Title: Chapter 06

1. Azure SQL Databases provide a relational database service targeted at online transaction processing or (OLTP; data entry, and retrieval transactions) workloads. 

2. You can up to six logical SQL Database servers Azure subscription. Each Database server can host a maximum of 5,000 databases and 45,000 DTUs.

3. The TrustServerCertificate property is set to false and the Encrpyt property is set to true to provide additional protection while accessing the SQL Database over the internet.

4. Transient errors are intermittent and likely will be resolved is the command is retried. transient errors can include the database connections being dropped during operation.

5. The three things that contribute to the cost of running a SQL server on a VM are the cost of the VM itself, the SQL Server licence, and the cost for Azure storage.

6. Disaster recovery of SQL Databases on VMs needs to be considered because geo-replication of multiple data disks is not consistent concerning the write order across disks. Additionally the VM may be online but the SQL Server instance may be offline, unhealthy, or both or the VM itself may be unavailable due to hardware failure or software upgrades. 

7. The features not currently provided by SQL Database are 
-windows authentication
-FILESTREAM Database-extended stored procedures
-SQL server agent/jobs
-SQL server reporting services and SQL server integration services 
-TSQL features including use statement, common language runtime, and cross database queries using 3 or 4 part names

8.Some of the factors to consider when choosing SQL Server or SQL Database are, database size, existing application vs new application, level of administrative control, business continuity strategy, and hybrid scenarios.

9.Microsoft collaborated with SuccessBricks to bring SuccessBricks clearDb database as a service for MYSQL to Azure.

10. A non relational database management system that Azure offers is DocumentDB or Azure Table storage. 