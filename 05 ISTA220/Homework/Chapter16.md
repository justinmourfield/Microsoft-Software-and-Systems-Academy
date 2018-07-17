### Author: Justin Mourfield
### Date : April 07, 2018
### Title: chapter16

1. 
~ - ~1=0
<</>> - 10<<1 = 20 // 10>1=5
| - 1|0=1
+ - 1+0=0
^ - 1^0=1
2. yes

3. bits & (1<<index); shift to the left by index and you are adding a specified amount of zeroes to the right side of the 1 index 

4. bits |= (1<<index); shift to the left by index and you are evaluating the places to true of both numbers have a 1 or a 1&0 but if both are 0 then it is false. 

5. bits &= (1<<index);shift to the left by index evaluate the places and only the places that have a 1 or 0 in the same place are true.

6. bool peek = bits [n] retireves bool at index n

7. sets the bit at index to true ir false

8. inverts the value of n 

9.
a-none 
b-read 
c-write 
d-read or write 
e-execute  
f-execute and read 
g-execute and write 
h- execute read and write 

10. 
001
010
100
it tells you that the indidivual permissions are dictated by the position of the 1 in the  binary number


