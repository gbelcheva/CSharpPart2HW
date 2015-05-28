//Problem 1. Odd or Even
//
//Write an expression that checks if given integer is odd or even.
//
//    Examples:
//n 	Odd?
//3 	true
//2 	false
//-2 	false
//-1 	true
//0 	false

var number1 = 3,
    number2 = 2,
    number3 = -2,
    number4 = -1,
    number5 = 0;

var numbers = [
    number1,
    number2,
    number3,
    number4,
    number5];

for (var index in numbers) {
    console.log('Is ' + numbers[index] + ' odd? -> ' + isOdd(numbers[index]));
}

function isOdd(number) {
    return !!(number % 2);
}