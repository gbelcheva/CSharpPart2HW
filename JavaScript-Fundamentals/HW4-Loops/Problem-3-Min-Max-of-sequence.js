//Problem 3. Min/Max of sequence
//
//Write a script that finds the max and min number from a sequence of numbers.

var numbers = [
    455,
    5955,
    99999,
    2,
    56,
    0,
    -5];

var min = numbers[0],
    max = numbers[0];


for (var i = 0; i < numbers.length; i++) {
    if (numbers[i] < min) {
        min = numbers[i];
    }
    if (numbers[i] > max) {
        max = numbers[i];
    }
}

console.log('min = ' + min);
console.log('max = ' + max);
