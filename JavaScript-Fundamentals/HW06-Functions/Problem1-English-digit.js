//Problem 1. English digit
//
//Write a function that returns the last digit of given integer as an English word.
//
//    Examples:
//input 	output
//512 	    two
//1024 	    four
//12309 	nine

var numbers = [
    512,
    1024,
    12309];

for (var num of numbers) {
    console.log(num + '  --> ' + getLastDigitAsWord(num));
}


function getLastDigitAsWord(number) {
    var digit = (number % 10) | 0;
    switch (digit) {
        case 0:
            digit = 'zero';
            break;
        case 1:
            digit = 'one';
            break;
        case 2:
            digit = 'two';
            break;
        case 3:
            digit = 'three';
            break;
        case 4:
            digit = 'four';
            break;
        case 5:
            digit = 'five';
            break;
        case 6:
            digit = 'six';
            break;
        case 7:
            digit = 'seven';
            break;
        case 8:
            digit = 'eight';
            break;
        case 9:
            digit = 'nine';
            break;
        default:
            break;
    }
    return digit;
}

