### Author: Justin Mourfield
### Date : March 18, 2018
### Title: chapter07

1. A windows function is the ability to create a scalar value for calculations done against a subset of rows in an underlying query.

2. Partition by restricts or limits the windown to a subset of rows that have the same values in the column as the current row. 

3.Order by specifies window ordering in terms of frame specification.
 
4. Rows between specifies an upper and lower boundary and filters a frame which is a subset of rows from the partitioned column. 

5. Ranking allows you to set an order of each row in a window. You would use it to get a specific layout of rows.

6. An offset window function returns information that is a certain distance (measured in rows) from the current row or at the beginning or end of a window.

7. Lag and Lead functions are used to obtain an element from a row that is a certain offset from the current row within the partition based upon the specified ordering. Lag looks before the row and Lead looks ahead. 

8. The first and last value commands are used to retrieve an element from the first or last rows in a window frame.

9. Aggregate window functions aggregate the rows defined in the window. 

10. Pivot tables are tables that have been rotated so that the row information is now columns. 
