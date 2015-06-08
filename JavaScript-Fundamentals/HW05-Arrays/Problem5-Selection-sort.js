//Problem 5. Selection sort
//
//Sorting an array means to arrange its elements in increasing order.
//    Write a script to sort an array.
//    Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
//
//    Hint: Use a second array

var i,
    len1;

var arrays = [
    [3, 2, 3, 4, 2, 2, 4],
    [1, 1, 1, 1, 1, 1, 2],
    [5, 5, 5, 5, 4, 4, 4, 4],
    [5, 6, 58, -2, 0, 0, 4, 4]];

for (i = 0, len1 = arrays.length; i < len1; i += 1) {
    console.log('[' + arrays[i].join(', ') + ']  -->  ' + arraySelectionSort(arrays[i]));

}

function arraySelectionSort(arr) {
    var j,
        k,
        len2,
        initialLen = arr.length,
        indexOfSmallest,
        sorted = [];
    for (k = 0; k < initialLen; k += 1) {
        indexOfSmallest = 0;
        for (j = 1, len2 = arr.length; j < len2; j += 1) {
            if (arr[j] < arr[indexOfSmallest]) {
                indexOfSmallest = j;
            }
        }
        //remove smallest element from initial array and push it to sorted array
        sorted.push(arr.splice(indexOfSmallest, 1)[0]);
    }
    return sorted.join(', ');
}