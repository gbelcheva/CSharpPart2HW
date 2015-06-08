//Problem 2. Reverse number
//
//Write a function that reverses the digits of given decimal number.
//
//    Example:
//input 	output
//256 	    652
//123.45 	54.321

var numbers = [
    256,
    123.45,
    -3.5];

for (var num of numbers)
{
    console.log(num + '  --> ' + reverseDigits(num));
}


function reverseDigits(number) {
    if (number < 0) {
        number = number.toString().slice(1);
        return Number('-' + number.split('').reverse().join(''));
    }
    return Number(number.toString().split('').reverse().join(''));
}
