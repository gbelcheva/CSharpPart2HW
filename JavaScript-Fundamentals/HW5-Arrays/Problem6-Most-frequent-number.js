//Problem 6. Most frequent number
//
//Write a script that finds the most frequent number in an array.
//
//    Example:
//input 	result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 	4 (5 times)

var i,
    len1,
    result;

var arrays = [
    [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    [3, 2, 3],
    [1, 1, 1, 1, 1, 1, 2],
    [5, 5, 5, 5, 4, 4, 4, 4],
    [5, 6, 58, -2, 0, 0, 4, 4]];

for (i = 0, len1 = arrays.length; i < len1; i += 1) {
    result = arrayMostFrequentElement(arrays[i]);
    console.log('[' + arrays[i].join(', ') + ']  -->  ' + result[0] + ' (' + result[1] + ' times)');

}

function arrayMostFrequentElement(arrInput) {
    var mostFrequent,
        j = 1,
        result,
        frequency = 1,
        tmpFrequency = 1,
        arr = arrInput.slice();
    for (var index in arr) {
        while (j < arr.length) {
            if (arr[j] === arr[index]) {
                tmpFrequency += 1;
                arr.splice(j, 1);
            }
            else {
                j += 1;
            }
        }
        if (frequency < tmpFrequency) {
            frequency = tmpFrequency;
            mostFrequent = arr[index];
        }
        tmpFrequency = 1;
        j = Number(index) + 2;
    }
    result = [mostFrequent, frequency];
    return result;
}