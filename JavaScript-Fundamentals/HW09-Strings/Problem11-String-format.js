//Problem 11. String format
//
//Write a function that formats a string using placeholders.
//    The function should work with up to 30 placeholders and all types.
//
//    Examples:
//
//var str = stringFormat('Hello {0}!', 'Peter');
////str = 'Hello Peter!';
//
//var frmt = '{0}, {1}, {0} text {2}';
//var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
////str = '1, Pesho, 1 text Gosho'

var frmt,
    str;

function stringFormat(){
    var i,
        len,
        string = arguments[0];
    for (i = 1, len = arguments.length; i < len; i += 1) {
        var placeholder = '{' + (i - 1) + '}',
            arg = arguments[i].toString();
        while(string.indexOf(placeholder) > -1){
            string = string.replace(placeholder, arg);
        }
    }
    return string;
}

console.log(stringFormat('Hello {0}!', 'Peter'));

frmt = '{0}, {1}, {0} text {2}';
str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
console.log(str);