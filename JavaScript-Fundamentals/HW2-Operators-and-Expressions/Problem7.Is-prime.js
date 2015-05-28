//Problem 7. Is prime
//
//Write an expression that checks if given positive integer number n (n ? 100) is prime.
//
//    Examples:
//n 	Prime?
//1 	false
//2 	true
//3 	true
//4 	false
//9 	false
//37 	true
//97 	true
//51 	false
//-3 	false
//0 	false

var i,
    j;

var number1 = 1,
    number2 = 2,
    number3 = 3,
    number4 = 4,
    number5 = 9,
    number6 = 37,
    number7 = 97,
    number8 = 51,
    number9 = -3,
    number10 = 0;

var numbers = [
    number1,
    number2,
    number3,
    number4,
    number5,
    number6,
    number7,
    number8,
    number9,
    number10];

for (i = 0; i < numbers.length; i += 1) {
    console.log('Is the number ' + numbers[i] + ' prime? -> ' + checkPrime(numbers[i]));
}


function checkPrime(number) {
    if (number < 2) {
        return false;
    }
    for (j = 2; j <= Math.sqrt(number); j += 1) {
        if (!(number % j)) {
            return false;
        }
    }
    return true;
}