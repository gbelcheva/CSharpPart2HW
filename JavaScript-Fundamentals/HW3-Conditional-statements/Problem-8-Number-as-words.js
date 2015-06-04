//Problem 8. Number as words
//
//Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
//
//    Examples:
//numbers 	number as words
//0 	Zero
//9 	Nine
//10 	Ten
//12 	Twelve
//19 	Nineteen
//25 	Twenty five
//98 	Ninety eight
//98 	Ninety eight
//273 	Two hundred and seventy three
//400 	Four hundred
//501 	Five hundred and one
//617 	Six hundred and seventeen
//711 	Seven hundred and eleven
//999 	Nine hundred and ninety nine

var input = [
    0 ,
    9 ,
    10,
    12,
    19,
    25,
    98,
    98,
    273,
    400,
    501,
    617,
    711,
    999];

for (var i = 0; i < input.length; i++) {
    var ones = input[i] % 10,
        tens = ((input[i] / 10) | 0) % 10,
        hundreds = ((input[i] / 100) | 0) % 10,
        words = '';

    if(input[i] < 1){
        words = 'zero';
    }
    else {
        if (hundreds) {
            words += getDigitWord(hundreds) + ' hundred';
            if (tens || ones){
                words += ' and ';
            }
        }
        if (tens) {
            if (!(tens === 1)){
                words += getDigitWord(tens * 10);
                if (ones) {
                    words += ' ' + getDigitWord(ones);
                }
            }
            else {
                words += getDigitWord(tens * 10 + ones);
            }
        }
        else {
            words += getDigitWord(ones);
        }
    }
    console.log(input[i] + ' -> ' + words.charAt(0).toUpperCase() + words.slice(1));
}

function getDigitWord (digit) {
    switch(digit){
        case 1: return 'one';
        case 2: return 'two';
        case 3: return 'three';
        case 4: return 'four';
        case 5: return 'five';
        case 6: return 'six';
        case 7: return 'seven';
        case 8: return 'eight';
        case 9: return 'nine';
        case 10: return 'ten';
        case 11: return 'eleven';
        case 12: return 'twelve';
        case 13: return 'thirteen';
        case 14: return 'fourteen';
        case 15: return 'fifteen';
        case 16: return 'sixteen';
        case 17: return 'seventeen';
        case 18: return 'eighteen';
        case 19: return 'nineteen';
        case 20: return 'twenty';
        case 30: return 'thirty';
        case 40: return 'forty';
        case 50: return 'fifty';
        case 60: return 'sixty';
        case 70: return 'seventy';
        case 80: return 'eighty';
        case 90: return 'ninety';
        default: return '';
    }
};


