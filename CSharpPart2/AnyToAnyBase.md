
Just do it like in base 10 or any other base, there's no different.
To convert a number in base X to base Y split the number in to integer part and fractional part.
Repeatedly divide the int part by Y and write the remainder in reverse direction.
For the fractional part repeatedly multiply it by Y and write the int part in forward direction.
For example: convert (2143.04)5 to base 7:

(2143)5 / (12)5 = (132)5  remains (4)5
(132)5 / (12)5 = (11)5 remains (0)5
(11)5 / (12)5 = (0)5 remains (11)5 = (6)7
=> (2143)5 = (604)7

(0.04)5*(12)5 = (1.03)5 =>  (1)5 = (1)7
(0.03)5*(12)5 = (0.41)5 => (0)5 = (0)7
(0.41)5*(12)5 = (10.42)5 => (10)5 = (5)7
(0.42)5*(12)5 = (11.04)5 => (11)5 = (6)7
(0.04)5*(12)5 = (1.03)5 => repeat
...
So (2143.04)5 = 604.(1056)

http://www.wolframalpha.com/input/?i=2143.04_5+in+base+7
