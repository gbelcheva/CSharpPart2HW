//Problem 2. Divisible by 7 and 5
//
//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
//
//    Examples:
//n 	Divided by 7 and 5?
//3 	false
//0 	true
//5 	false
//7 	false
//35 	true
//140 	true

var number1 = 3,
    number2 = 0,
    number3 = 5,
    number4 = 7,
    number5 = 35,
    number6 = 140;

var numbers = [
    number1,
    number2,
    number3,
    number4,
    number5,
    number6];

for (var index in numbers) {
    console.log('Is ' + numbers[index] + ' divisible by 5 and 7? -> ' + isDivisibleBy5And7(numbers[index]));
}

function isDivisibleBy5And7(number) {
    return (!(number % 5) && !(number % 7));
}
