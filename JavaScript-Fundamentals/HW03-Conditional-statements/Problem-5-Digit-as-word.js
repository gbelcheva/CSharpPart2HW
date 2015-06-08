//Problem 5. Digit as word
//
//Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid input.
//    Use a switch statement.
//
//    Examples:
//    digit 	result
//    2 	two
//    1 	one
//    0 	zero
//    5 	five
//    -0.1 	not a digit
//    hi 	not a digit
//    9 	nine
//    10 	not a digit

var input1 = 2,
    input2 = 1,
    input3 = 0,
    input4 = 5,
    input5 = -0.1,
    input6 = 'hi',
    input7 = 9,
    input8 = 10;

var input = [
    input1,
    input2,
    input3,
    input4,
    input5,
    input6,
    input7,
    input8];


for (var i = 0; i < input.length; i++) {
    var digit;
    switch(input[i]){
        case 0: digit = 'zero';
            break;
        case 1: digit = 'one';
            break;
        case 2: digit = 'two';
            break;
        case 3: digit = 'three';
            break;
        case 4: digit = 'four';
            break;
        case 5: digit = 'five';
            break;
        case 6: digit = 'six';
            break;
        case 7: digit = 'seven';
            break;
        case 8: digit = 'eight';
            break;
        case 9: digit = 'nine';
            break;
        default: digit = 'not a digit';
            break;
    }
    console.log(input[i] + ' -> ' + digit);
}
//
//console.log("Type some text and press <ENTER>:\t");
//var userInput = readline();
//console.log("User input: " + userInput);