//Problem 7. Binary search
//
//Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.


var i,
    len1;

var searchedElements = [
    8,
    3,
    2,
    0,
    -2];

var arrays = [
    [1, 2, 3, 4, 5, 6, 7, 8, 9, 10],
    [2, 3, 3],
    [1, 1, 1, 1, 1, 1, 2],
    [4, 4, 4, 4, 5, 5, 5],
    [-2, 0, 0, 4, 4, 5, 6, 58]];

for (i = 0, len1 = arrays.length; i < len1; i += 1) {
    console.log('[' + arrays[i].join(', ') + '] --> ' + searchedElements[i] + ' is at index --> ' + arrayBinarySearch(arrays[i], searchedElements[i]));

}

function arrayBinarySearch(array, element) {
    var currentIndex,
        arr = array.slice(),
        start = 0,
        end = arr.length;
    while (end - start > 0) {
        currentIndex = ((end + start) / 2) | 0;
        if (arr[currentIndex] === element) {
            return currentIndex;
        }
        else {
            if (element < arr[currentIndex]) {
                end = currentIndex;
            }
            else {
                start = currentIndex + 1;
            }
        }
    }
    return 'element does not exist in the array'
}