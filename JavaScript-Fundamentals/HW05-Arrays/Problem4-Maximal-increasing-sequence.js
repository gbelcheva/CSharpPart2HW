//Problem 4. Maximal increasing sequence
//
//Write a script that finds the maximal increasing sequence in an array.
//
//    Example:
//input 	                result
//3, 2, 3, 4, 2, 2, 4 	    2, 3, 4

var i,
    len1;

var arrays = [
    [3, 2, 3, 4, 2, 2, 4],
    [1, 1, 1, 1, 1, 1, 2],
    [5, 5, 5, 5, 4, 4, 4, 4]];

for (i = 0, len1 = arrays.length; i < len1; i += 1) {
    console.log('[' + arrays[i].join(', ') + ']  -->  ' + arrayMaxSequence(arrays[i]));

}

function arrayMaxSequence(arr) {
    var j,
        len2,
        tmpSequence = [arr[0]],
        maxSequence = [arr[0]];
    for (j = 1, len2 = arr.length; j < len2; j += 1) {
        if (arr[j - 1] < arr[j]) {
            tmpSequence.push(arr[j]);
        }
        else {
            tmpSequence = [arr[j]];
        }
        if (tmpSequence.length > maxSequence.length) {
            maxSequence = tmpSequence.slice();
        }
    }
    return maxSequence.join(', ');
}