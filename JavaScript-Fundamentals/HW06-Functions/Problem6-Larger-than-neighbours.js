//Problem 6. Larger than neighbours
//
//Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).


var arr = [
        8,
        5,
        7,
        7,
        66,
        645,
        4,
        5,
        987,
        321],
    elements = [
        4,
        987,
        8,
        7];

for (var element of elements) {
    console.log(element + ' --> ' + checkLargerThanNeighbours(arr, element));
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