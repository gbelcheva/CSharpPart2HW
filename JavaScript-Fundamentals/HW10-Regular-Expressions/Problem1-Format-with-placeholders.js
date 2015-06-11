//Problem 1. Format with placeholders
//
//    Write a function that formats a string. The function should have placeholders, as shown in the example
//Add the function to the String.prototype
//
//Example:
//    input 	                                            output
//var options = {name: 'John'};
//'Hello, there! Are you #{name}?'.format(options); 	'Hello, there! Are you John'
//var options = {name: 'John', age: 13};
//'My name is #{name} and I am #{age}-years-old').format(options); 	'My name is John and I am 13-years-old'

var input1 = 'Hello, there! Are you #{name}?',
    options1 = {name: 'John'},
    input2 = 'My name is #{name} and I am #{age}-years-old',
    options2 = {name: 'John', age: 13};


String.prototype.format = function (options) {
    var result = this,
        regexInput = /#{[^}]+}/i;
    while (result.search(regexInput) > -1) {
        var tmpPlaceholder = result.match(regexInput)[0];
        if (Object.prototype.hasOwnProperty.call(options, tmpPlaceholder.match(/{(.*)}/)[1])) {
            var value = options[tmpPlaceholder.match(/{(.*)}/)[1]];
            result = result.replace(tmpPlaceholder, value);
        }
    }
    return result;
};

console.log(input1.format(options1));
console.log(input2.format(options2));