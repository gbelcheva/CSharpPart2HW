//Problem 1. Reverse string
//
//Write a JavaScript function that reverses a string and returns it.
//
//    Example:
//input 	output
//sample 	elpmas

var string = 'sample';

function reverseString (string){
    return string.split('').reverse().join('');
}

console.log(string + ' --> ' + reverseString(string));