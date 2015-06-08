//Problem 4. Third digit
//
//Write an expression that checks for given integer if its third digit (right-to-left) is 7.
//
//Examples:
//n 	Third digit 7?
//5 	false
//701 	true
//1732 	true
//9703 	true
//877 	false
//777877 	false
//9999799 	true

var number1 = 5,
    number2 = 701,
    number3 = 1732,
    number4 = 9703,
    number5 = 877,
    number6 = 777877,
    number7 = 9999799;

var numbers = [
    number1,
    number2,
    number3,
    number4,
    number5,
    number6,
    number7];

for (var index in numbers) {
    console.log('Is the third digit of ' + numbers[index] + ' seven? -> ' + isThirdDigit7(numbers[index]));
}

function isThirdDigit7(number) {
    //divide the number by 100, take the last digit, OR it with 0 to take only the integer part, check if it's 7
    return (((number / 100) % 10) | 0) === 7;
}