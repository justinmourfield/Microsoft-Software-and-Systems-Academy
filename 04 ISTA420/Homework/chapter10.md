### Author: Justin Mourfield
### Date : May 26, 2018
### Title: chapter10

1. A transaction is a unit of work that might iclude multiple activities that query and modify data and that can also change the data definition.

2. 
-Atomicity- means either all changes take place or none will take place. Its a fail safe.
-Consistency- refers to the state of the data that the relational database managemenent system gives you access to as a concurrent transactions modify or query it. 
-Isolation- ensures that the transactions access only consistent data. 
-Durability- Data changes are always written to the databases transaction log on disk before they are written to the data portion of the database on disk.

3.Granularity in locks refers to the collection echelon level that needs to be locked for the transaction. ie. Table lock is needed for a row transaction 

4.the mode of the lock refers to a categorization that a transaction or falls within. 

5.Blocking is the process of preventing multiple lock requests that are conflicting on the same resource. ie a transaction needing a shared lock but a row is exclusively locked by another session

6.the properties of the sys.dm_tran_locks are session_id, resource_type, resource_db_id, resource_desc, resource_associated, reques_mode, request_status

7.the properties of the sys.dm_exec_connections are session_id AS sid,connect_time, last_read, last_write, most_recent_sql_handle.

8.he properties of the sys.dm_exec_requests are session_id AS sid, login_time, host_name, program_name, login_name, nt_user_name, last_request_start_time, last_request_end_time.

9.Isolation levels determine the level of consistency you get when you interact with data. select *from crimedata with read committed

10. serializable means -Statements cannot read data that has been modified but not yet committed by other transactions. No other transactions can modify data that has been read by the current transaction until the current transaction completes. Other transactions cannot insert new rows with key values that would fall in the range of keys read by any statements in the current transaction until the current transaction completes. 

11. A deadlock is a situation in which two or more sessions block each other. 
