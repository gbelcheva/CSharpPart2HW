//Problem 2. Lexicographically comparison
//
//Write a script that compares two char arrays lexicographically (letter by letter).

var i,
    len1;

var arrays1 = [['a', 'b', 'c', 'd'], ['A', 'b', 'c', 'd'], ['a', 'c', 'b', 'd'], ['a', 'b', 'c', 'd']],
    arrays2 = [['a', 'b', 'c', 'd'], ['a', 'b', 'c', 'd'], ['a', 'b', 'c', 'd'], ['a', 'c', 'b', 'd']];


for (i = 0, len1 = arrays1.length; i < len1; i += 1) {
    console.log('[' + arrays1[i] + '] [' + arrays2[i] + '] -> ' + arrayCompare(arrays1[i], arrays2[i]));

}

//0 if equal, -1 if first is smaller, 1 if first is larger
function arrayCompare(arr1, arr2) {
    var j,
        len2;
    if (arr1.length !== arr2.length) {
        return (arr1.length < arr2.length) ? -1 : 1;
    }
    for (j = 0, len2 = arr1.length; j < len2; j += 1) {
        if (arr1[j].toLowerCase() === arr2[j].toLowerCase()) {
            continue;
        }
        return (arr1[j].toLowerCase() < arr2[j].toLowerCase()) ? -1 : 1;
    }
    return 0;
}

