//Problem 5. Third bit
//
//Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
//    The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.
//
//Examples:
//n 	binary representation 	bit #3
//5 	00000000 00000101 	0
//8 	00000000 00001000 	1
//0 	00000000 00000000 	0
//15 	00000000 00001111 	1
//5343 	00010100 11011111 	1
//62241 	11110011 00100001 	0

var number1 = 5,
    number2 = 8,
    number3 = 0,
    number4 = 15,
    number5 = 5343,
    number6 = 62241;

var numbers = [
    number1,
    number2,
    number3,
    number4,
    number5,
    number6];

for (var index in numbers) {
    console.log(
        'The third bit of ' +
        numbers[index] +
        ' (' + ('000000000000000' + (numbers[index] >>> 0).toString(2)).slice(-16) + ') is -> ' +
        getThirdBit(numbers[index])
    );
}

function getThirdBit(number) {
    return (number >> 3) & 1;
}