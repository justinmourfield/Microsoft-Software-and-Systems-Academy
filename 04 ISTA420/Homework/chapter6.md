### Author: Justin Mourfield
### Date : March 12, 2018
### Title: chapter06

1. Set operators are operators that combine rows from two query result sets.

2. The general requirements of a set operator are that the two queries must produce the same number of column and corresponding columns have the compatible data types. the data type of the column must be the same and the amount of columns in the tables must be the same. 

3. Two circles with an overlapping area that illustrates two things and their sub-factors and any common factors they have are listed in the center.

4. A union operator combines the results of the input query and populate but will not include redundant columns. Its implicitly DISTINCT. 

5. (Union all) will include redundant columns.

6. The intersect operator will only show what is present in both tables. or essentially the center of a Venn diagram.

7. If intersect all was implemented, it will populate the lower number of occurrences of duplicate intersections.  

8. Except implement set differences implicitly DISTINCT. it will populate results of columns that are contained in table one but not table two. 

9. Except all takes into account the amount of redundant sets of the two evaluated sets and populates the x-y of those sets. more simplistically, it reports back rows from the first multi-set that do not have a corresponding occurrence in the second multi-set.

10. Intersect, then Union and except are evaluated in the order of their appearance. 
