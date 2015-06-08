//Problem 7. First larger than neighbours
//
//Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
//    Use the function from the previous exercise.

var arrays = [[8, 5, 7, 7, 66, 645, 4, 5, 987, 321],
    [1, 1, 1]];

for (var arr of arrays) {
    console.log(arr + ' --> ' + findLargerThanNeighbours(arr));
}


function findLargerThanNeighbours(array){
    var i,
        len;
    for (i = 1, len = array.length - 1; i < len; i++) {
        if (checkLargerThanNeighbours(array, array[i]) === true) {
            return i;
        }
    }
    return -1;
}

function checkLargerThanNeighbours(array, element){
    var elementIndex = array.indexOf(element);
    if (0 === elementIndex || elementIndex === (array.length - 1)) {
        return element + ' is border element. Not all neighbours exist.';
    }
    if (elementIndex === -1) {
        return 'No such element exists.';
    }
    if (array[elementIndex - 1] < element && array[elementIndex + 1] < element) {
        return true;
    }
    return false;
}