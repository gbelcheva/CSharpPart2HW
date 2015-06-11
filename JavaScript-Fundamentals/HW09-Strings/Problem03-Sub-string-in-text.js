//Problem 3. Sub-string in text
//
//Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
//
//Example:
//
//    The target sub-string is in
//
//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//
//The result is: 9

var text = 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.',
    substr = 'in';

function countSubstring(text, substr){
    var i,
        textLen = text.length,
        substrLen = substr.length,
        count = 0;
    for (i = 0; i < textLen - substrLen; i += 1) {
        var t = text.substr(i, substrLen).toLowerCase();
        if (t === substr.toLowerCase()) {
            count += 1;
        }
    }
    return count;
}

console.log('\'' + substr + '\' --> ' + countSubstring(text, substr) + ' times');