//Problem 3. Maximal sequence
//
//Write a script that finds the maximal sequence of equal elements in an array.
//
//    Example:
//input 	                        result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1 	    2, 2, 2

var i,
    len1;

var arrays = [
    [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
    [1, 2, 2, 2, 2, 2, 2],
    [5, 5, 5, 5, 4, 4, 4, 4]];

for (i = 0, len1 = arrays.length; i < len1; i += 1) {
    console.log('[' + arrays[i].join(', ') + ']  -->  ' + arrayMaxSequence(arrays[i]));

}

function arrayMaxSequence(arr) {
    var j,
        len2,
        tmp = 1,
        maxLen = 1,
        maxElement;
    for (j = 0, len2 = arr.length - 1; j < len2; j += 1) {
        if (arr[j] === arr[j + 1]) {
            tmp += 1;
        }
        else {
            tmp = 1;
        }
        if (tmp > maxLen) {
            maxLen = tmp;
            maxElement = arr[j]
        }
    }
    return Array(maxLen + 1).join(maxElement).split('').join(', ');
}