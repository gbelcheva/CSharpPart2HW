//Problem 5. Appearance count
//
//Write a function that counts how many times given number appears in given array.
//    Write a test function to check if the function is working correctly.

var arr = [
    6545,
    564,
    654,
    654,
    345,
    45,
    444,
    -4,
    -4,
    44,
    4,
    4,
    4,
    4
],
    num = -4;

console.log(num + ' --> ' + countNumberAppearance(arr, num) + ' (' + check(arr, num, 2) + ')');

function countNumberAppearance(array, number){
    var count = 0;
    for (var element of array) {
        if (element === number) {
            count += 1;
        }
    }
    return count;
}

function check(array, number, expectedAppearance){
    return countNumberAppearance(array,number) === expectedAppearance;
}